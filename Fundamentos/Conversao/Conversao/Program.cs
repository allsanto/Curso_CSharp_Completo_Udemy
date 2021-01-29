using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implicita
            //byte num1 = 100; // 8 bits, de 0 a 255
            //ushort num2; // 16 bits, 0 a 65.535

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num3 = num1;
            //num2 = num1;

            //// num1 = num2; // Gera erro

            //char letra = 'C';
            //int numero = 'C'; // Converte para o código numero, por que a varivel é int

            //Console.WriteLine(numero);
            //Console.ReadKey();
            #endregion

            #region Conversão Explicita
            //ushort num1 = 500;
            //byte num2 = (byte)num1; // para fazer a conversão basta colocar (o tipo)variavelx;

            //float num3 = 2500.786f;
            //int num4 = (int)num3;

            //char letra = (char)9657;

            //Console.WriteLine(letra);
            //Console.ReadKey();
            #endregion

            #region Método Parse
            //string txtNumero = "1985";

            //int numero = int.Parse(txtNumero); // int.Parse - Converte String para int

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57"); // Quando eu coloco a virgula, considera porque não é literal

            //float num3 = float.Parse("455,57"); // Não precisa do F

            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.ReadKey();
            #endregion

            #region Classe Convert
            // O "Convert." converte uma variavel para qualquer Tipo
            string texto = Convert.ToString(2500);
            string texto2 = Convert.ToString(false);

            double num1 = Convert.ToDouble(false);
            double num2 = Convert.ToDouble(true);

            //Conversão que não da certo
            int num3 = Convert.ToInt32('C');
            //double num4 = Convert.ToDouble('C'); // Gera erro

            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            //Console.WriteLine(num4);
            Console.ReadKey();
            #endregion
        }
    }
}
