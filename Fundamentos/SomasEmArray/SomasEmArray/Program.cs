using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomasEmArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite os Valores: ");
            var numeros = Console.ReadLine();
            double[] outputInt = Array.ConvertAll(numeros.Split(' '), str => double.Parse(str));

            Console.Write("Digite os Valores: ");
            var numeros2 = Console.ReadLine();
            double[] outputInt2 = Array.ConvertAll(numeros2.Split(' '), str2 => double.Parse(str2));


            double num1 = outputInt[0];
            double num2 = outputInt[1];
            double num3 = outputInt[2];

            double num10 = outputInt2[0];
            double num20 = outputInt2[1];
            double num30 = outputInt2[2];

            double tratamento = num2 * num3;
            double tratamento2 = num20 * num30;
            double soma = tratamento + tratamento2;

            Console.WriteLine("VALOR A PAGAR: " + soma);
            Console.ReadKey();
        }
    }
}
