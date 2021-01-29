using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Allan"); // Imprime o texto e pula a linha
            // Console.Write("Teste Allan"); // Imprime porem não quebra a linha.

            // int codigo = Console.Read(); // Pega o primeiro caracter
            // Console.WriteLine(codigo);

            // Captura uma sequencia de caracteres de uma linha inteira
            string texto = Console.ReadLine();
            Console.WriteLine(texto);

            Console.ReadKey(); // Armazena uma tecla do teclado ou para pausar no console.
        }
    }
}
