using MG_Reserva.Controle.Util;
using MG_Reserva.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Logica
{
    static class Reserva
    {
        /// <summary>
        /// Recebe uma lista de Salas e um valor de pessoas, verifica quais salas tem capacidade para comportar o dado numero e retorna uma nova lista de Salas com apenas aquelas que passarem no filtro.
        /// </summary>
        /// <returns>Uma lista de Salas que comporta a quantidade de pessoas especificadas.</returns>
        public static List<Sala> FiltrarSalasPorTamanho(List<Sala> salas, int pessoas)
        {
            List<Sala> salas_aptas = new List<Sala>();

            return salas.FindAll(sala => sala.Tamanho >= pessoas);
        }

        /// <summary>
        /// Recebe uma lista de Salas e um valor de pessoas, verifica quais salas tem capacidade para comportar o dado numero e retorna uma nova lista de Salas com apenas aquelas que passarem no filtro.
        /// </summary>
        /// <returns>Uma lista de Salas que comporta a quantidade de pessoas especificadas.</returns>
        public static List<Sala> FiltrarSalasPorRecursos(List<Sala> salas, string[] recursos)
        {
            List<Sala> salas_aptas = new List<Sala>();

            salas_aptas = salas.FindAll(sala =>
            {
                return sala.Recursos.ToArray().Intersect(recursos).Count() == recursos.Length;
            });

            salas_aptas.Sort(delegate(Sala sala1, Sala sala2)
            {
                if (sala1.Recursos.Count() > sala2.Recursos.Count()) return 1;
                if (sala1.Recursos.Count() < sala2.Recursos.Count()) return -1;
                return 0;
            });

            return salas_aptas;

        }

        /// <summary>
        /// Recebe uma lista de Salas a data/horário de inicio e de termino, verifica quais salas têm horários disponíveis e retorna uma nova lista de Salas, que passaram no filtro, em ordem de recursos decrescente, ou seja, as primeiras salas são as que dispõe de menos recursos. 
        /// </summary>
        /// <returns>Uma lista de Salas</returns>
        public static List<Sala> FiltrarSalasPorHorario(List<Sala> salas, DateTime inicio, DateTime fim)
        {
            List<Sala> salas_aptas = new List<Sala>();

            return salas.FindAll(sala => !ConflitoDeHorario(sala, inicio, fim));

        }

        /// <summary>
        /// Recebe um objeto Sala e dois arrays de int, o início e o fim de um horário, verifica se este está em conflito com alguma reunião já marcada.
        /// Caso tenha conflito, retorna um array de strings com dois horário sugeridos, um para inicio e outro para fim.
        /// Caso não tenha conflito, o string terá o valor 0 no lugar de ambos os horários. 
        /// </summary>
        /// <returns>
        /// Um array de string com dois horários, formatados (dia/mes/ano horas:minutos).
        /// </returns>
        public static bool ConflitoDeHorario(Sala sala, DateTime inicio, DateTime fim)
        {

            foreach (Reuniao reuniao_marcada in sala.Reunioes)
            {
                // Confirma se a nova reunião não está entre alguma já existente.
                int[] conflitos = {
                    DateTime.Compare(reuniao_marcada.Inicio, fim),
                    DateTime.Compare(reuniao_marcada.Fim, inicio)
                };

                // Garante que uma reunião não começe ou termine enquanto uma outra já esteja acontecendo.
                if (conflitos[0] <= 0 || conflitos[1] >= 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static Sala Reservar(Sala sala, DateTime inicio, DateTime fim)
        {
            sala.Reunioes.Add(new Reuniao(inicio, fim));

            return sala;
        }

        /// <summary>
        /// Recebe um array com duas datas e uma lista de Salas.
        /// Retorna três sugestões de datas/horários, onde as mesmas usam o tempo da reunião para projetar um novo horário à frente.
        /// </summary>
        /// <returns>Uma lista com três data/horários</returns>
        public static List<DateTime[]> SugerirReservas(DateTime[] datas, List<Sala> salas_aptas)
        {
            var duracao = (datas[1] - datas[0]);
            List<DateTime[]> reservas_sugeridas = new List<DateTime[]>();

            for (int i = 0; i < 3; i++)
            {
                datas[0] = datas[0].AddHours(duracao.TotalHours);
                datas[1] = datas[1].AddHours(duracao.TotalHours);

                reservas_sugeridas.Add(new[] { datas[0], datas[1] });
            }

            return reservas_sugeridas;
        }


        public static string ValidarDatas(DateTime inicio, DateTime fim)
        {
            if (inicio < DateTime.Now.AddDays(1))
            {
                return "Reuniões devem ser marcadas com, no mínimo, 1 dia de antecedência.";
            }

            if (inicio > DateTime.Now.AddDays(40))
            {
                return "Reuniões devem ser marcadas com, no máximo, 40 dia de antecedência.";
            }

            if ((fim - inicio).TotalHours > 8)
            {
                return "Reuniões devem durar no máximo 8 horas.";
            }

            if (inicio.DayOfWeek == DayOfWeek.Sunday || inicio.DayOfWeek == DayOfWeek.Saturday)
            {
                return "Reuniões devem ser marcadas apenas em dias úteis.";
            }

            return "";
        }

    }
}
