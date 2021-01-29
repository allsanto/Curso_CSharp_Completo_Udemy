using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            // int[] numeros = new int[5];

            // numeros[0] = 10;
            // numeros[1] = 20;
            // numeros[2] = 30;
            // numeros[3] = 40;
            // numeros[4] = 50;

            // numeros[2] = 55;

            // string[] nomes = new string[3];
            // string[] nomes2 = { 
            //     "Gabriel", 
            //     "Rafael", 
            //     "Dany" 
            // };

            // nomes2[2] = "Logan";

            // nomes[0] = "Allan";
            // nomes[1] = "Felipe";
            // nomes[2] = "Matheus";

            // Console.WriteLine(numeros[4]);
            // Console.WriteLine(nomes[0]);
            // Console.WriteLine(nomes2[2]);
            // Console.ReadKey();
            #endregion

            #region Matriz
            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.WriteLine(numeros[0,1]);

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.WriteLine("[" + numeros[1, 2] + "]");
            
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            string[,] nomes =
            {
                { "Allan", "Danny", "Gabriel"},
                { "Flavio", "Gloria", "Bia"}
            };

            Console.Write("[" + nomes[0, 0] + "]");
            Console.Write("[" + nomes[0, 1] + "]");
            Console.Write("[" + nomes[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + nomes[1, 0] + "]");
            Console.Write("[" + nomes[1, 1] + "]");
            Console.Write("[" + nomes[1, 2] + "]");
            Console.ReadKey();
            #endregion
        }
    }
}
