using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo While
            //int valor = int.Parse(Console.ReadLine());

            //while (valor <= 10) // Enquanto for verdadeiro continua rodando
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++; // Incrementa 1
            //}
            //Console.ReadKey();
            #endregion

            #region Do While
            //Console.Write("Digite um valor: ");
            //int valor = int.Parse(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //} while (valor < 10);

            //Console.ReadKey();
            #endregion

            #region Ciclo FOR
            //for (int i = 0, j = 10; i <= 10; i++, j--)
            //{
            //    Console.WriteLine("I =" + i + " | J = " + j);

            //}
            //Console.ReadKey();
            #endregion

            #region Ciclo Foreach

            string[] nomes = { "Gabriel", "Allan", "Felipe", "Maria" };

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            Console.ReadKey();
            #endregion
        }
    }
}

