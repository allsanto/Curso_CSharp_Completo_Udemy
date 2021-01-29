using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matemáticos
            //int num1 = 15;
            //int num2 = 2;
            ////int resultado = num1 + num2

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);
            //Console.ReadKey();
            #endregion

            #region Precedência de Operadores
            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;

            //double res = num1 + num2 * num3;
            //double res2 = (num1 + num2) * num3;
            //double res3 = (num1 + num2) * num3 / 2;
            //double res4 = (num1 + num2) * (num3 / 3);

            //Console.WriteLine(res);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            //Console.ReadKey();
            #endregion

            #region Incremento e Decremento
            //int num1 = 10;

            // num1 = num1 + 1;
            // num1++;
            // ++num1;
            // num1--;
            // ++num1;

            //Console.WriteLine(num1++); // Incrementa 1
            //Console.WriteLine(num1); // Imprime o valore
            //Console.WriteLine(--num1); // Retira 1

            //Console.WriteLine(--num1); // retira 1 
            //Console.WriteLine(num1); // Imprime
            //Console.WriteLine(num1--); // o -- não vale
            //Console.ReadKey();
            #endregion

            #region Concatenação
            ////string nome = "Gabriel " + "Artigas "; // Literal
            ////string sobreNome = "Santos ";
            ////string nomeCompleto = nome + sobreNome + "1997"; // Forma de Função

            ////Console.WriteLine(nomeCompleto);
            ////Console.ReadKey();
            #endregion

            #region Operadores Atribuição
            //double num1 = 10;
            //double num2 = 10;
            //double num3 = 10;
            //double num4 = 10;
            ////num1 = num1 + 20;
            //num1 += 20;
            //num2 -= 2;
            //num3 *= 2;
            //num4 /= 2;
            //num4 %= 2;

            //string nome = "Allan";
            //nome += " Feitosa";

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(num4);
            //Console.WriteLine(nome);
            //Console.ReadKey();
            #endregion

            #region Igualdade / Comparação
            //bool res = 100 == 50; // 100 é igual a 50 ? false
            //bool res1 = 100 == 100; // 100 é igual a 50 ? true
            //bool res2 = 100 == 2 * 50; // 100 é igual a 50 ? true

            //bool res3 = 200 != 100; // 200 é diferente de 100 ? true
            //bool res4 = 200 != 200; // 200 é diferente de 100 ? false
            //bool res5 = (200 / 2) != (100 + 100); // 200 é diferente de 100 ? true

            //string nome = "Allan";
            //bool res6 = nome == "Santos";

            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            //Console.WriteLine(res5);
            //Console.WriteLine(res6);
            //Console.ReadKey();
            #endregion

            #region Operadores Relacionais
            //bool res = 100 < 50; // false
            //bool res1 = 100 < 50 + 65; // True
            //bool res2 = 100 < 50 * 2; // false

            //bool res3 = 100 > 50 * 2; // false
            //bool res4 = 100 + 25 > 50 * 2; // true

            //bool res5 = 100 + 25 <= 50 * 2; // false
            //bool res6 = 45 <= 50 * 2; // true

            //bool res7 = 100 + 25 >= 50 * 2;// true
            //bool res8 = 45 >= 50 * 2; // false

            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res4);
            //Console.WriteLine(res5);
            //Console.WriteLine(res6);
            //Console.WriteLine(res7);
            //Console.WriteLine(res8);
            //Console.ReadKey();
            #endregion

            #region Operadores Lógicos AND ou OR
            bool res1 = 100 > 50; // true
            bool res2 = 50 == 50; // true
            bool res3 = 50 != 50; // false

            bool final = res1 && res2; // true
            bool final2 = res1 && res3; // false

            bool final3 = res1 || res3; // false

            Console.WriteLine(final);
            Console.WriteLine(final2);
            Console.WriteLine(final3);
            Console.ReadKey();
            #endregion
        }
    }
}
