﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciamentoMemoria
{
    public class GerenciamentoLru
    {
        private int pagina1 = 0;
        private int pagina2 = 0;
        private int pagina3 = 0;
        private int i = 0;
        private List<int> entradas = new List<int>();
        private List<int> historiocPagina1 = new List<int>();
        private List<int> historiocPagina2 = new List<int>();
        private List<int> historiocPagina3 = new List<int>();

        public void SimularGerenciamentoLru()
        {
            ImpotarEntradas impotarEntradas = new ImpotarEntradas();
            entradas = impotarEntradas.CarregarEntradas();

            for (i = 0; i < entradas.Count; i++)
            {
                if (i == 0)
                {
                    pagina1 = entradas[i];

                    AtualizarHisotico();
                    MostraHistorico();
                }
                else if (i == 1)
                {
                    pagina2 = entradas[i];

                    AtualizarHisotico();
                    MostraHistorico();
                }
                else if (i == 2)
                {
                    pagina3 = entradas[i];

                    AtualizarHisotico();
                    MostraHistorico();
                }
                else
                {
                    if (pagina1 == entradas[i])
                    {
                        AtualizarHisotico();
                        MostraHistorico();
                    }
                    else if (pagina2 == entradas[i])
                    {
                        AtualizarHisotico();
                        MostraHistorico();
                    }
                    else if (pagina3 == entradas[i])
                    {
                        AtualizarHisotico();
                        MostraHistorico();
                    }
                    else
                    {
                        int distanciaPagina1 = ContarDistancia(pagina1, i);
                        int distanciaPagina2 = ContarDistancia(pagina2, i);
                        int distanciaPagina3 = ContarDistancia(pagina3, i);

                        if ((distanciaPagina1 > distanciaPagina2) && (distanciaPagina1 > distanciaPagina3))
                        {
                            pagina1 = entradas[i];

                            AtualizarHisotico();
                            MostraHistorico();
                        }
                        else if ((distanciaPagina2 > distanciaPagina1) && (distanciaPagina2 > distanciaPagina3))
                        {
                            pagina2 = entradas[i];

                            AtualizarHisotico();
                            MostraHistorico();
                        }
                        else
                        {
                            pagina3 = entradas[i];

                            AtualizarHisotico();
                            MostraHistorico();
                        }
                    }

                }

                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        public int ContarDistancia(int valorPagina, int posicaoInicial)
        {
            int contador = 0;
            for (int i = posicaoInicial; i >= 0; i--)
            {
                contador++;
                if (entradas[i] == valorPagina)
                {
                    return contador;
                }
            }

            return 9999;
        }

        public void AtualizarHisotico()
        {
            new Thread(() => {
                historiocPagina1.Add(pagina1);
                historiocPagina2.Add(pagina2);
                historiocPagina3.Add(pagina3);
            }).Start();
            Thread.Sleep(10);
        }

        public void MostraHistorico() {
            Console.WriteLine("Entrada: "  + entradas[i]);
            Console.WriteLine("Pagina 1: " + historiocPagina1[i]);
            Console.WriteLine("Pagina 2: " + historiocPagina2[i]);
            Console.WriteLine("Pagina 3: " + historiocPagina3[i]);
        }

    }
}
