using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Controle.Util
{
    static class Conversor
    {
        public static DateTime ToDateTime(int[] valores)
        {
            if (valores.Length  == 3)
            {
                return new DateTime(
                            valores[2], // Ano
                            valores[1], // Mes
                            valores[0]); // Dia
            }

            if(valores.Length > 3)
            {
                return new DateTime(
                            valores[2], // Ano
                            valores[1], // Mes
                            valores[0], // Dia
                            valores[3], // Horas
                            valores[4], // Minutos
                            0);
            }

            return new DateTime();
        }

        public static DateTime StringToDateTime(string data, string hora = "")
        {
            int[] valores;
            if (hora != "")
            {
                valores = Array.ConvertAll(
                            data
                            .Split('-')
                            .ToArray()
                            .Concat(hora.Split(':').ToArray()).ToArray(),
                        int.Parse);

                return ToDateTime(valores);
            }
            else
            {

                valores = Array.ConvertAll(
                            data
                            .Split('-')
                            .ToArray(),
                        int.Parse);

                return ToDateTime(valores);
            }
        }
    }
}
