using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Teste
{
    class Gerador
    {
        public List<string> testes = new List<string> {
            "23-06-2019;10:00;23-06-2019;12:00;10;Sim;Sim", // Dia não útil
            "25-06-2019;1:33;25-06-2019;12:11;10;Sim;Sim", // 12 horas de reunião
            "25-06-2019;11:44;25-06-2019;12:14;10;Sim;Sim",
            "25-06-2019;13:42;25-06-2019;13:15;10;Sim;Sim",
            "25-06-2019;16:12;25-06-2019;20:26;10;Sim;Sim",
            "25-06-2019;01:24;25-06-2019;08:52;10;Sim;Sim",
            "25-08-2019;05:23;25-08-2019;12:13;10;Sim;Sim", // Mais de 40 dias de antecedencia
            "25-06-2019;17:57;25-06-2019;21:00;10;Sim;Sim",
            "25-06-2019;07:00;25-06-2019;14:30;10;Sim;Sim",
            "25-06-2019;11:00;25-06-2019;12:00;10;Sim;Sim",
            "20-06-2019;10:00;20-06-2019;12:00;10;Não;Não",
            "01-06-2019;10:00;01-06-2019;12:00;10;Não;Não", // Menos que 1 dia de antecedencia
        };

        public List<string> salas = new List<string> {
            "1;10;C;I;W",
            "2;10;C;I;W",
            "3;10;C;I;W",
            "4;10;C;I;W",
            "5;10;C;I;W",
            "6;10;I",
            "7;10;I",
            "8;3;C;I;W",
            "9;3;C;I;W",
            "10;3;C;I;W",
            "11;20",
            "12;20",
        };

        public List<string> TestePadrao()
        {
            return this.testes;
        }

        public List<string> SalasPadrao()
        {
            return this.salas;
        }

    }
}
