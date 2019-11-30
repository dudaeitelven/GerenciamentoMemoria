using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMemoria
{
    public class ImpotarEntradas
    {
        public List<int> CarregarEntradas()
        {
            List<int> Entradas = new List<int>();
            string FileToRead = "entradas.txt";

            //Carregando o arquivo com os tweets
            using (StreamReader sr = File.OpenText(FileToRead))
            {
                while (!sr.EndOfStream)
                {
                    string[] linha = sr.ReadLine().Split(',');

                    try
                    {
                        Entradas.Add(Convert.ToInt32(linha[0]));
                    }
                    catch (Exception e)
                    {
                        Entradas.Add(Convert.ToInt32(0));
                    }

                }
            }

            return Entradas;
        }

    }
}
