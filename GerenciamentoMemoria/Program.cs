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


            entradas.Add(7);
            entradas.Add(9);
            entradas.Add(1);
            entradas.Add(2);
            entradas.Add(9);
            
            entradas.Add(3);
            entradas.Add(9);
            entradas.Add(4);
            entradas.Add(2);
            entradas.Add(4);
            
            entradas.Add(9);
            entradas.Add(3);
            entradas.Add(2);
            entradas.Add(1);
            entradas.Add(2);

            entradas.Add(9);
            entradas.Add(1);
            entradas.Add(7);
            entradas.Add(9);
            entradas.Add(1);

        
            for (int i = 0; i < entradas.Count; i++)
            {

                    if (pagina1 == 0)
                {
                    pagina1 = entradas[i];
                    Console.WriteLine("pagina 1: " + pagina1);
                    Console.WriteLine("pagina 2: " + pagina2);
                    Console.WriteLine("pagina 3: " + pagina3);
                }
                else if (pagina2 == 0)
                {
                    pagina2 = entradas[i];
                    Console.WriteLine("pagina 1: " + pagina1);
                    Console.WriteLine("pagina 2: " + pagina2);
                    Console.WriteLine("pagina 3: " + pagina3);
                }
                else if (pagina3 == 0)
                {
                    pagina3 = entradas[i];
                    Console.WriteLine("pagina 1: " + pagina1);
                    Console.WriteLine("pagina 2: " + pagina2);
                    Console.WriteLine("pagina 3: " + pagina3);
                }
                else {
                    if (pagina1 == entradas[i])
                    {
                        //Console.WriteLine("pagina 1: " + pagina1);
                        //Console.WriteLine("pagina 2: " + pagina2);
                        //Console.WriteLine("pagina 3: " + pagina3);
                    }
                    else if (pagina2 == entradas[i])
                    {
                        //Console.WriteLine("pagina 1: " + pagina1);
                        //Console.WriteLine("pagina 2: " + pagina2);
                        //Console.WriteLine("pagina 3: " + pagina3);
                    }
                    else if (pagina3 == entradas[i])
                    {
                        //Console.WriteLine("pagina 1: " + pagina1);
                        //Console.WriteLine("pagina 2: " + pagina2);
                        //Console.WriteLine("pagina 3: " + pagina3);
                    }
                    else {
                       // int dintanciaPagina1 = contarDistancia(pagina1,entradas,i);
                        int dintanciaPagina2 = 0;
                        int dintanciaPagina3 = 0;

                    }



                }






                Console.WriteLine("");
                //Console.Write($"{entradas[i]} ");
            }
           

            Console.ReadKey();







            //new Thread(() => {
                
            //});

        }

        public int contarDistancia(int valorPagina, List<int> entradas,int posicaoInicial)
        {     
            for (int i = posicaoInicial; i < entradas.Count; i++)
            {  
                if (entradas[i] == valorPagina) 
                {
                    return i;
                }
            }

            return 9999;
        }



    }
}
