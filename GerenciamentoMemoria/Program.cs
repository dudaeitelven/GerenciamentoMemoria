using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagina1 = 0;
            int pagina2 = 0;
            int pagina3 = 0;
            List<int> entradas         = new List<int>();
            List<int> historiocPagina1 = new List<int>();
            List<int> historiocPagina2 = new List<int>();
            List<int> historiocPagina3 = new List<int>();


            entradas.Add(66);
            entradas.Add(55);
            entradas.Add(44);
            entradas.Add(33);
            entradas.Add(22);
            foreach (int number in entradas)
            {
                if (pagina1 != 0)
                {

                }
                else if (pagina2 != 0) {

                }
                else if (pagina3 != 0)
                {

                }
               





                Console.Write($"{number} ");
            }
            Console.WriteLine();

            Console.ReadKey();







            //new Thread(() => {
                
            //});

        }

    }
}
