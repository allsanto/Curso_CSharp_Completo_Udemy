using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condição Simples IF e ELSE
            //Console.Write("Digite um valor: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num < 5)
            //{
            //    Console.WriteLine("Condição Verdadeira");
            //}
            //else
            //{
            //    Console.WriteLine("Condição Falsa");
            //}
            //Console.ReadKey();
            #endregion

            #region Condição Encadeada
            //Console.Write("Digite um valor: ");
            //int num1 = int.Parse(Console.ReadLine());

            //if (num1 < 5)
            //{
            //    Console.WriteLine("Condição Verdadeira");
            //}
            //else if (num1 >= 5 && num1 < 10)
            //{
            //    Console.WriteLine("Condição alternativa 1");
            //}
            //else if (num1 >= 10 && num1 < 20)
            //{
            //    Console.WriteLine("Condição alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição alternativa final");
            //}
            //Console.ReadKey();
            #endregion

            #region Condição Condicionais Alinhadas
            //Console.Write("Digite um numero: ");
            //int numero = int.Parse(Console.ReadLine());

            //if (numero > 5)
            //{
            //    Console.Write("O numero é maior que 5");
            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e tambem é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" mas não é par.");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region Operador Ternario
            Console.Write("Digite um numero ");
            int numero = int.Parse(Console.ReadLine());
            string mensagem = numero >= 5 ? "Maior que 5" : "Menor que 5";

            //Operador ternario - (numero > 5)Condição ? true : false;
            //mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            //if (numero > 5)
            //{
            //    mensagem = "maior que 5";
            //}
            //else
            //{
            //    mensagem = "menor que 5";
            //}

            Console.WriteLine(numero >= 5 ? "Maior que 5" : "Menor que 5");
            Console.WriteLine(mensagem);
            Console.ReadKey();
            #endregion
        }
    }
}
