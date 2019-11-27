using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMemoria
{
    public class GerenciamentoOtimo
    {
        private int pagina1 = 0;
        private int pagina2 = 0;
        private int pagina3 = 0;
        private int i = 0;
        private List<int> entradas = new List<int>();
        private List<int> historiocPagina1 = new List<int>();
        private List<int> historiocPagina2 = new List<int>();
        private List<int> historiocPagina3 = new List<int>();

        public void SimularGerenciamentoOtimo()
        {
            entradas.Add(7);
            entradas.Add(9);
            entradas.Add(1);
            
            entradas.Add(2);
            entradas.Add(9);
            entradas.Add(3);
            
            entradas.Add(9);
            entradas.Add(4);
            entradas.Add(2);
            
            entradas.Add(3);
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

                if (i == 0)
                {
                    pagina1 = entradas[i];

                    historiocPagina1.Add(pagina1);
                    historiocPagina2.Add(pagina2);
                    historiocPagina3.Add(pagina3);

                    Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                    Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                    Console.WriteLine("pagina 3: " + historiocPagina3[i]);
                }
                else if (i == 1)
                {
                    pagina2 = entradas[i];

                    historiocPagina1.Add(pagina1);
                    historiocPagina2.Add(pagina2);
                    historiocPagina3.Add(pagina3);

                    Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                    Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                    Console.WriteLine("pagina 3: " + historiocPagina3[i]);
                }
                else if (i == 2)
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
                        int distanciaPagina1 = contarDistancia(pagina1, i);
                        int distanciaPagina2 = contarDistancia(pagina2, i);
                        int distanciaPagina3 = contarDistancia(pagina3, i);

                        if ((distanciaPagina1 > distanciaPagina2) && (distanciaPagina1 >= distanciaPagina3))
                        {
                            pagina1 = entradas[i];

                            historiocPagina1.Add(pagina1);
                            historiocPagina2.Add(pagina2);
                            historiocPagina3.Add(pagina3);

                            Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                            Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                            Console.WriteLine("pagina 3: " + historiocPagina3[i]);

                        }
                        else if ((distanciaPagina2 > distanciaPagina1) && (distanciaPagina2 > distanciaPagina3))
                        {
                            pagina2 = entradas[i];

                            historiocPagina1.Add(pagina1);
                            historiocPagina2.Add(pagina2);
                            historiocPagina3.Add(pagina3);

                            Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                            Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                            Console.WriteLine("pagina 3: " + historiocPagina3[i]);


                        }
                        else {
                            pagina3 = entradas[i];

                            historiocPagina1.Add(pagina1);
                            historiocPagina2.Add(pagina2);
                            historiocPagina3.Add(pagina3);

                            Console.WriteLine("pagina 1: " + historiocPagina1[i]);
                            Console.WriteLine("pagina 2: " + historiocPagina2[i]);
                            Console.WriteLine("pagina 3: " + historiocPagina3[i]);
                        }



                    }

                }


                Console.WriteLine("");
                //Console.Write($"{entradas[i]} ");
            }


            Console.ReadKey();

            //new Thread(() => {

            //});
        }

        public int contarDistancia(int valorPagina, int posicaoInicial)
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
