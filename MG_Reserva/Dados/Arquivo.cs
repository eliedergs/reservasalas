using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG_Reserva.Dados
{
    class Arquivo
    {
        public string caminho_entradas = "Entradas";
        public string caminho_saidas = "Saidas";

        public Arquivo()
        {
            if (!System.IO.Directory.Exists("Entradas"))
            {
                System.IO.Directory.CreateDirectory("Entradas");
            }

            if (!System.IO.Directory.Exists("Saidas"))
            {
                System.IO.Directory.CreateDirectory("Saidas");
            }
        }
        public List<string> LerArquivo(string nome_arquivo)
        {
            string linha;
            string caminho = $"{caminho_entradas}\\{nome_arquivo}.txt";


            List<string> entradas = new List<string>();

            if (File.Exists(caminho))
            {
                StreamReader file = new StreamReader(caminho);
                entradas.Add($"Arquivo lido: {caminho}\n");

                while ((linha = file.ReadLine()) != null)
                {
                    entradas.Add(linha);
                }

                

                file.Close();
            } else
            {
                entradas.Add(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            }



            return entradas;
        }

        public void SalvarEmArquivo(string nome_arquivo, List<string> dados, bool entrada = false)
        {
            string caminho = !entrada ? 
                $"{caminho_saidas}\\{nome_arquivo}.txt" :
                $"{caminho_entradas}\\{nome_arquivo}.txt";

            using (StreamWriter sw = new StreamWriter(caminho))
            {
                foreach (string dado in dados)
                {
                    sw.WriteLine(dado);
                }
                sw.Flush();
                sw.Close();
            }
        }
    }
}
