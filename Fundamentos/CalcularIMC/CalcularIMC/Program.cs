using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Feito Antes
            //Console.Write("Informe o peso em Kg: ");
            //double peso = double.Parse(Console.ReadLine());

            //Console.Write("Informe a altura em metros: ");
            //double altura = double.Parse(Console.ReadLine());

            //double valorIMC = peso / (altura * altura);

            //if (valorIMC < 20)
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Abaixo do peso.");
            //}
            //else if ((valorIMC >= 20) && (valorIMC <= 24))
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Normal.");
            //}
            //else if ((valorIMC >= 25) && (valorIMC <= 29))
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Acima do peso.");
            //}
            //else if ((valorIMC >= 30) && (valorIMC <= 34))
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Obeso.");
            //}
            //else
            //{
            //    Console.WriteLine("\nIMC = " + valorIMC + " -> Muito Obeso.");
            //}
            //Console.ReadKey();
            #endregion

            #region Pratica
            Console.Write("Informe o Peso em Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe sua Altura: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);
            double IMC = Math.Round(valorIMC, 2);

            if (valorIMC <= 18.5)
            {
                Console.WriteLine("IMC de " + IMC + ", Abaixo do Peso");
            }
            else if ((IMC >= 18.6) && (IMC <= 24.99))
            {
                Console.WriteLine("IMC de " + IMC + ", com Peso Normal");
            }
            else if ((IMC >= 25) && (IMC <= 29.99))
            {
                Console.WriteLine("IMC de " + IMC + ", com Sobrepeso");
            }
            else if ((IMC >= 30) && (IMC <= 34.99))
            {
                Console.WriteLine("IMC de " + IMC + ", Obesidade Grau 1");
            }
            else if ((IMC >= 35) && (IMC <= 39.99))
            {
                Console.WriteLine("IMC de " + IMC + ", Obesidade Grau 2");
            }
            else
            {
                Console.WriteLine("IMC de " + IMC + ", Obesiade Grau 3 ou Mórbida");
            }

            Console.ReadKey();
            #endregion
        }
    }
}
