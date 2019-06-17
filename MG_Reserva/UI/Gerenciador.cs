using MG_Reserva.Controle;
using MG_Reserva.Controle.Util;
using MG_Reserva.Teste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_Reserva
{
    public partial class Gerenciador : Form
    {
        private ControladorLogica controlador;
        private bool[] validar_enviar = new[] {
            false, // data_inicio
            false, // data_fim
            false, // tamanho
            false, // data
        };

        public Gerenciador()
        {
            InitializeComponent();
            
            this.controlador = ControladorLogica.Controlador;

            this.controlador.CriarSalas(ControladorTeste.GerarSalas(true));

            this.GerarTesteInicial();

            btnEnviar.Enabled = false;
        }

        private void GerarTesteInicial()
        {
            // Cria o arquivo de teste que será processado logo após a inicialização do programa.
            var arquivo_teste = "TesteAutomatico";
            ControladorTeste.GerarArquivoTeste(true);
            var entrada = this.controlador.IniciarPorArquivo(arquivo_teste);

            // Apresenta no log as entradas de teste.
            this.logEntrada.Text = "";
            foreach (string linha in entrada)
            {
                this.logEntrada.Text += $"{linha}\n";
            }

            this.logEntrada.Text += "\nClique em \"Reservar\" para iniciar...";

        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            logSaida.Text = "Processando...";
            var resultados = this.controlador.Processar();
            logSaida.Text = "";
            foreach (var resultado in resultados)
            {
                logSaida.Text += $"{resultado}\n";
            }
        }
        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.textData.Text = $"{e.Start.ToString("dd/MM/yyyy")}";
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string data = textData.Text.Replace('/', '-');

            string hora_inicio = textHoraInicio.Text;
            textHoraInicio.Text = "";

            string hora_fim = textHoraFim.Text;
            textHoraFim.Text = "";

            int tamanho = Convert.ToInt32(numericTamanho.Value);
            numericTamanho.Value = 0;

            string internet = checkInternet.Checked ? "Sim" : "Não";
            checkInternet.Checked = false;

            string webcam = checkWebCam.Checked ? "Sim" : "Não";
            checkWebCam.Checked = false;

            logArquivoReservas.Text += ($"{data};{hora_inicio};{data};{hora_fim};{tamanho};{internet};{webcam}\n");

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (textNomeArquivo.Text == "")
                textNomeArquivo.Text = "NovasReservas";

            this.controlador.SalvarPorDadosEntrada(textNomeArquivo.Text, logArquivoReservas.Text);

            logArquivoReservas.Text = "";

            var entrada = controlador.IniciarPorArquivo(textNomeArquivo.Text);

            // Apresenta no log as entradas de teste.
            this.logEntrada.Text = "";
            foreach (string linha in entrada)
            {
                this.logEntrada.Text += $"{linha}\n";
            }

            this.logEntrada.Text += "\nClique em \"Reservar\" para iniciar...";
        }

        private void TextHoraInicio_TextChanged(object sender = null, EventArgs e = null)
        {
            if (textHoraInicio.Text.Trim().Length > 1)
            {
                validar_enviar[0] = true;
                btnEnviar.Enabled = LiberarValidacao();
            }
            else validar_enviar[0] = false;
        }

        private void TextHoraFim_TextChanged(object sender, EventArgs e)
        {
            if (textHoraFim.Text.Trim().Length > 1)
            {
                validar_enviar[1] = true;
                btnEnviar.Enabled = LiberarValidacao();
            }
            else validar_enviar[1] = false;
        }

        private void NumericTamanho_ValueChanged(object sender, EventArgs e)
        {
            if (numericTamanho.Value > 0)
            {
                validar_enviar[2] = true;
                btnEnviar.Enabled = LiberarValidacao();
            }
            else validar_enviar[2] = false;
        }

        private bool LiberarValidacao()
        {
            foreach (bool valido in validar_enviar)
            {
                if (!valido)
                    return false;
            }

            return true;
        }

        private void TextData_TextChanged(object sender, EventArgs e)
        {
            int[] data = Array.ConvertAll(textData.Text.Split('/'), int.Parse);
            var data_reuniao = Conversor.ToDateTime(data);
            if (data_reuniao.DayOfWeek == DayOfWeek.Sunday ||
                data_reuniao.DayOfWeek == DayOfWeek.Saturday)
            {
                labelAlertaData.Visible = true;
                this.validar_enviar[3] = false;
            }
            else
            {
                labelAlertaData.Visible = false;
                this.validar_enviar[3] = true;
            }
            btnEnviar.Enabled = LiberarValidacao();
        }
    }
}
