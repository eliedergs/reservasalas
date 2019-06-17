using MG_Reserva.Controle.Util;
using MG_Reserva.Dados;
using MG_Reserva.Logica;
using MG_Reserva.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Controle
{
    class ControladorLogica
    {
        private static readonly ControladorLogica controlador = new ControladorLogica();
        public static ControladorLogica Controlador
        {
            get
            {
                return controlador;
            }
        }


        private List<Sala> salas;
        public ControladorLogica()
        {
            this.salas = new List<Sala>();
        }

        public void CriarSalas(List<string> info_salas)
        {

            foreach (string info_sala in info_salas)
            {
                var info = info_sala.Split(';');

                var nova_sala = new Sala(Convert.ToInt32(info[0]), Convert.ToInt32(info[1]));

                for (int i = 2; i < info.Length; i++)
                {
                    nova_sala.Recursos.Add(info[i]);
                }

                salas.Add(nova_sala);
            }
        }

        public List<string> IniciarPorArquivo(string caminho)
        {
            return ControladorDados.BuscarArquivo(caminho);
        }

        public void SalvarPorDadosEntrada(string nome_arquivo, string dados)
        {
            ControladorDados.Salvar(nome_arquivo, dados.Trim().Split('\n').ToList(), true);
        }

        public List<string> Processar()
        {
            List<string> resultados = new List<string>();
            List<string> reservas = ControladorDados.cache.Skip(1).ToList();

            foreach(string reserva in reservas)
            {
                List<Sala> salas_filtradas;
                List<string> recursos = new List<string>();

                string[] info_reserva = reserva.Split(';');

                
                DateTime inicio_reuniao = Conversor.StringToDateTime(info_reserva[0], info_reserva[1]);
                DateTime fim_reuniao = Conversor.StringToDateTime(info_reserva[2], info_reserva[3]);
                
                // Validação das datas
                string validar_datas = Reserva.ValidarDatas(inicio_reuniao, fim_reuniao);
                if (validar_datas != "")
                {
                    resultados.Add(validar_datas);
                    continue;
                }

                int tamanho = Convert.ToInt32(info_reserva[4]);

                if (info_reserva[5] == "Sim") recursos.Add("I");
                if (info_reserva[6] == "Sim") recursos.Add("W");

                // Filtra as salas que comportam a quantidade requerida.
                salas_filtradas = Reserva.FiltrarSalasPorTamanho(salas, tamanho);

                if (salas_filtradas.Count() <= 0)
                {
                    resultados.Add("Não existe sala que comporte a quantidade de pessoas requeridas.");
                    continue;
                }

                // Filtra as salas que têm os recursos disponíveis.
                salas_filtradas = Reserva.FiltrarSalasPorRecursos(salas_filtradas, recursos.ToArray());

                // Filtra as salas que têm horários na data requerida.
                var salas_com_horario = Reserva.FiltrarSalasPorHorario(salas_filtradas, inicio_reuniao, fim_reuniao);

                // Caso haja alguma sala que passe em todos os filtros, a reunião é reservada.
                if (salas_com_horario.Count() > 0)
                {
                    Reserva.Reservar(salas_com_horario.First(), inicio_reuniao, fim_reuniao);
                    resultados.Add($"Sala {salas_com_horario.First().Numero}");
                }
                // Caso não sobre nenhuma sala, nenhuma reserva é feita, sendo retornado três sugestões de datas/horários.
                else
                {
                    string resposta = "Não há salas disponíveis.\n" +
                        "Sugestão de horários:\n";

                    var reservas_sugeridas = Reserva.SugerirReservas(
                        new[] { inicio_reuniao, fim_reuniao },
                        salas_filtradas
                    );

                    foreach (DateTime[] reserva_sugerida in reservas_sugeridas)
                    {
                        resposta += $"  Início: {reserva_sugerida[0].ToString("dd/MM/yyyy HH:mm")}\n";
                        resposta += $"  Fim: {reserva_sugerida[1].ToString("dd/MM/yyyy HH:mm")}\n\n";
                    }

                    resultados.Add(resposta);
                }


            }

            ControladorDados.Salvar("SaidaTesteAutomatico", resultados);


            return resultados;
        
        }

        public string[] UltimoArquivoCarregado()
        {
            return ControladorDados.cache;
        }
    }
}