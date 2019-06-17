using MG_Reserva.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Dados
{
    static class ControladorDados
    {
        private static Arquivo arquivo = new Arquivo();

        public static string[] cache;

        private static bool gravar_em_arquivo = true;
        public static void GravarEmArquivo(bool comando)
        {
            gravar_em_arquivo = comando;
        }

        public static void Salvar(string nome, List<string> dados, bool entrada = false)
        {
            if (gravar_em_arquivo)
            {
                arquivo.SalvarEmArquivo(nome, dados, entrada);
            }
        }

        public static List<string> BuscarArquivo(string nome_arquivo)
        {
            var resultado = arquivo.LerArquivo(nome_arquivo);

            cache = resultado.ToArray();

            return resultado;
        }
    }
}
