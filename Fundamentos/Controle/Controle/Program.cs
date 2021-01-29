using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch - Case
            //Console.Write("Escolha um numero: ");
            //int escolha = int.Parse(Console.ReadLine());

            //switch (escolha)
            //{
            //    default:
            //        Console.WriteLine("Opção Default");
            //        break;
            //    case 1:
            //        Console.WriteLine("Opção 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Opção 2");
            //        break;
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Opção Combinada");
            //        break;
            //}
            //Console.ReadKey();
            #endregion

            #region Praticando Switch Case
            //Inicio:
            //Console.Write("Digite um valor: ");
            //int num = int.Parse(Console.ReadLine());

            //switch (num)
            //{
            //    default:
            //        Console.WriteLine("Opção Invalida.");
            //        goto Inicio;
            //        break;
            //    case 1:
            //        Console.WriteLine("Opção 1 - São Paulo");
            //        break;
            //    case 2:
            //        Console.WriteLine("Opção 2 - Rio de Janeiro");
            //        break;
            //    case 3:
            //        Console.WriteLine("Opção 3 - Santo Catarina");
            //        break;
            //    case 4:
            //        Console.WriteLine("Opção 4 - Pernambuco");
            //        break;
            //    case 5:
            //    case 15:
            //        Console.WriteLine("Opção 5 - Bahia");
            //        break;
            //}
            //Console.ReadKey();

            #endregion

            #region Goto
            //Inicio: // Label 
            //Console.Write("Escolha uma opção: ");
            //int op = int.Parse(Console.ReadLine());
            //int valor = 0;

            //switch (op)
            //{
            //    default:
            //        goto Inicio;
            //    case 1:
            //        valor += 100;
            //        break;
            //    case 2:
            //        valor += 50;
            //        goto case 1;
            //}


            //Console.WriteLine("Valor final " + valor);
            //Console.ReadKey();
            #endregion

            #region Treino Switch case e Goto

            Console.WriteLine("Qual sorvete você deseja?");
        Inicio:
            Console.WriteLine("Morango   R$ 10,00 reais");
            Console.WriteLine("Chocolate R$ 15,00 reais");
            Console.WriteLine("Limão     R$ 18,00 reais");
            Console.WriteLine("Trufado   R$ 25,00 reais");
            Console.WriteLine("Senão digite zero(0) para sair.");
            Console.Write("Digete o valor: ");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                default:
                    Console.WriteLine("\nEscolha uma opção valida abaixo.");
                    goto Inicio;
                case 10:
                    Console.Write("Morango por R$ 10,00 reais.");
                    break;
                case 15:
                    Console.Write("Chocolate por R$ 15,00 reais.");
                    break;
                case 18:
                    Console.Write("Limão por R$ 18,00 reais.");
                    break;
                case 25:
                    Console.Write("Trufado por R$ 25,00 reais.");
                    break;
                case 0:
                    Console.Write("Obrigado");
                    break;
            }
            Console.ReadKey();
            #endregion
        }
    }
}
