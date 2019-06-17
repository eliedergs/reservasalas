using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Modelos
{
    class Sala
    {
        public int Numero { get; }
        public int Tamanho { get; }
        public List<string> Recursos { get; set; }
        public List<Reuniao> Reunioes { get; set; }

        public Sala(int _numero, int _tamanho)
        {
            this.Numero = _numero;
            this.Tamanho = _tamanho;
            this.Recursos = new List<string>();
            this.Reunioes = new List<Reuniao>();
        }
    }
}
