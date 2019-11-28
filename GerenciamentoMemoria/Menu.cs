using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMemoria
{
    public class Menu
    {
        public void Iniciar()
        {
            int opcao=-1;

            while (opcao != 0)
            {
                MostrarMenu();
                opcao = EscolherOpcao();

                switch (opcao)
                {
                    case 1:
                        GerenciamentoOtimo gerenciamentoOtimo = new GerenciamentoOtimo();
                        gerenciamentoOtimo.SimularGerenciamentoOtimo();

                        break;
                    case 2:
                        GerenciamentoLru gerenciamentoLru = new GerenciamentoLru();
                        gerenciamentoLru.SimularGerenciamentoLru();

                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente!");
                        Console.ReadKey();                        
                        break;
                }
            }
           
        }

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| 1 - Gerenciamento de memória Ótimo |");
            Console.WriteLine("| 2 - Gerenciamento de memória LRU   |");
            Console.WriteLine("| 0 - Sair                           |");
            Console.WriteLine("|------------------------------------|");
        }

        public int EscolherOpcao()
        {
            int opcao = 0;
            Boolean passou = false;

            while (passou == false)
            {
                try
                {
                    Console.WriteLine("Escolha sua opção:");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    passou = true;
                }
                catch (Exception e)
                {
                    passou = false;
                    Console.WriteLine("Insira apenas números!");
                }
            }
            return opcao;
        }
    }


}
