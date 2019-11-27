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
            int i = 0;
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

        
            for (i = 0; i < entradas.Count; i++)
            {

                if (i==0)
                {
                    pagina1 = entradas[i];

                    historiocPagina1.Add(pagina1);
                    historiocPagina2.Add(pagina2);
                    historiocPagina3.Add(pagina3);

                    Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                    Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                    Console.WriteLine("pagina 3: " + historiocPagina3[i]);
                }
                else if (i==1)
                {
                    pagina2 = entradas[i];

                    historiocPagina1.Add(pagina1);
                    historiocPagina2.Add(pagina2);
                    historiocPagina3.Add(pagina3);

                    Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                    Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                    Console.WriteLine("pagina 3: " + historiocPagina3[i]);
                }
                else if (i==2)
                {
                    pagina3 = entradas[i];

                    historiocPagina1.Add(pagina1);
                    historiocPagina2.Add(pagina2);
                    historiocPagina3.Add(pagina3);

                    Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                    Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                    Console.WriteLine("pagina 3: " + historiocPagina3[i]);
                }
                else
                {
                    if (pagina1 == entradas[i])
                    {

                        historiocPagina1.Add(pagina1);
                        historiocPagina2.Add(pagina2);
                        historiocPagina3.Add(pagina3);
                        Console.WriteLine("pagina 1: " + pagina1);
                        Console.WriteLine("pagina 2: " + pagina2);
                        Console.WriteLine("pagina 3: " + pagina3);
                        


                    }
                    else if (pagina2 == entradas[i])
                    {
                        historiocPagina1.Add(pagina1);
                        historiocPagina2.Add(pagina2);
                        historiocPagina3.Add(pagina3);
                        Console.WriteLine("pagina 1: " + pagina1);
                        Console.WriteLine("pagina 2: " + pagina2);
                        Console.WriteLine("pagina 3: " + pagina3);
                      

                    }
                    else if (pagina3 == entradas[i])
                    {

                        historiocPagina1.Add(pagina1);
                        historiocPagina2.Add(pagina2);
                        historiocPagina3.Add(pagina3);
                        Console.WriteLine("pagina 1: " + pagina1);
                        Console.WriteLine("pagina 2: " + pagina2);
                        Console.WriteLine("pagina 3: " + pagina3);
                        
                    }
                    else
                    {
                        int distanciaPagina1 = contarDistancia(pagina1,entradas,i);
                        int distanciaPagina2 = 0;
                        int distanciaPagina3 = 0;

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
