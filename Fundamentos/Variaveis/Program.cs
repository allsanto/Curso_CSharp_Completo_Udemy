using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        enum Notas
        { // O "enum" cria uma inomeração
            Minimo = 10,
            Media = 20,
            Maxima = 30
        }


        struct Pessoa // Cria uma estrutura de dados para armazenar valores de um Tipo
        { 
            public string nome; // Public é um modificador de acesso, que define que os dados são publicos 
            public int idade;
            public double altura;
        }
        struct Endereco{
            public string Rua;
            public int Numero;
            public string Complemento;
            public string PontoReferencia;
        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            // Integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, de -32.768 a 32.767
            //int num3 = 30; // 32 bits, de -2.147.483.648 a 2.147.483.647
            //long num4 = 40; // 64 bits, de -9.233.372.036.854.775.807 a 9.233.372.036.854.775.807

            //// Integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 10; // 16 byts, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero; // Referenciada
            //numero = 100;

            //numero = 120;
            //numero = num1;

            //Console.WriteLine(numero);
            //Console.ReadKey();
            #endregion

            #region Numeros Reais
            //float real1 = 100.75f; // 32 bits, Quando a variavel for do tipo Float deve colocar a letra "F"
            //double real2 = 12500.45; // 64 bits, Não precisa de uma Letra
            //decimal real3 = 753538.457m; // 128 bits, Precisa da letra "m"

            //double valor;
            //valor = 500;
            //valor = real1;

            //Console.WriteLine(valor);
            //Console.ReadKey();

            #endregion

            #region Variaveis do Tipo Char
            // Armazena apenas 1 caractere.
            //char letra = 'C';
            //char letra2 = '\u0061'; // Códigos exadecimais, verificar na tabela
            //char escape = '\n';
            //char escape2 = '\\';
            //char literal = 'C';

            //Console.WriteLine(letra);
            //Console.WriteLine(letra2);
            //Console.ReadKey();
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;

            //Console.WriteLine(verificar);
            //Console.ReadKey();
            #endregion

            #region String (Cadeia de Caracteres)
            //string texto = @"Gabriel Artigas ou \\n \n 1985 @@??$$"; // Com "@" ignoro os caracteres especiais
            //string mensagem = null; // Variavel referenciada
            //mensagem = texto;

            //Console.WriteLine(mensagem);
            //Console.ReadKey();
            #endregion

            #region Variavel do Tipo "VAR"
            //O tipo "Var" o compilador define o seu tipo
            //var valor = 140; // Sera inteiro até o final
            //var valor1 = "Gabriel"; // Sera String até o final
            //var valor2 = false; // Sera boolean
            //// valor = "Gabriel"; Gera erro pois ja foi declarada

            //Console.WriteLine();
            //Console.ReadKey();
            #endregion

            #region Variavel do tipo Objeto
            //É uma variavel das quais todas variaveis herdam
            //Unifica todos os tipos de variaveis
            //object obj = false; // Podemos atribuir qualquer valor
            //obj = 200;
            //obj = "Allan";

            //Console.WriteLine(obj);
            //Console.ReadKey();
            #endregion

            #region Variavel do tipo Constante "Const"
            // Ela tem um valor constante que asume o valor até o final
            // O valor que ela receber não sera alterado

            //const double pi = 3.1415;
            //pi = 25; -Gera erro pois o valor da constantes não pode ser alterado

            //const string nome = "Allan";

            //Console.WriteLine(pi);
            //Console.WriteLine(nome);
            //Console.ReadKey();
            #endregion

            #region Inomeração - Cria o nosso tipo de variavel
            // Guarda 3 tipos de inomerações
            // Minimo - Médio - Maximo
            Notas notasAlunos = Notas.Media;

            Console.WriteLine(notasAlunos);
            Console.ReadKey();
            #endregion

            #region Entruturas
            // Cria uma estrutura de dados
            //Pessoa p1 = new Pessoa(); // o "NEW" diz que sera uma nova estrutura do tipo Pessoa
            //p1.altura = 1.65;
            //p1.idade = 35;
            //p1.nome = "Allan";

            //Pessoa p2 = new Pessoa()
            //{
            //    nome = "Arthur",
            //    idade = 9,
            //    altura = 1.35
            //};

            //p1.nome = "Logan";


            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.idade);
            //Console.WriteLine(p1.altura);

            //Console.WriteLine(p1.nome + " " + p1.altura + " " + p1.idade);

            //Console.WriteLine("\n");

            //Console.WriteLine(p2.nome);
            //Console.WriteLine(p2.idade);
            //Console.WriteLine(p2.altura);

            //Console.WriteLine(p2.nome + " " + p2.altura + " " + p2.idade);

            //Console.ReadKey();
            #endregion
        }
    }
}