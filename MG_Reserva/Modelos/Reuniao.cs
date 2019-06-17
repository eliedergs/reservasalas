using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Modelos
{
    class Reuniao
    {
        public DateTime Inicio { get; }
        public DateTime Fim { get; }

        public Reuniao(DateTime _inicio, DateTime _fim)
        {
            this.Inicio = _inicio;
            this.Fim = _fim;
        }

        public TimeSpan TempoReservado()
        {
            return (this.Fim - this.Inicio);
        }
    }
}
