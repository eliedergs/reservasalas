using MG_Reserva.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Teste
{
    static class ControladorTeste
    {
        private static readonly Gerador gerador = new Gerador();
        public static bool GerarArquivoTeste(bool padrao = true)
        {
            if (padrao)
            {
                ControladorDados.Salvar("TesteAutomatico", gerador.TestePadrao(), true);
            }

            return true;
        }

        public static List<string> GerarSalas(bool padrao = true)
        {
            if (padrao)
            {
                return gerador.SalasPadrao();
            }

            return new List<string>();
        }
    }
}
