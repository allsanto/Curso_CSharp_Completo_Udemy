using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        #region Forma Aprendida
        //Inicio:
        //    Console.Clear();

        //    Console.Write("Digite o Primeiro número: ");
        //    double num1 = double.Parse(Console.ReadLine());

        //    Console.Write("Digite o Segundo número: ");
        //    double num2 = double.Parse(Console.ReadLine());

        //    Console.Write("Escolha a operaçao (+ - x /): ");
        //    char op = char.Parse(Console.ReadLine());

        //    double resultado = 0;

        //    switch (op)
        //    {
        //        default:
        //            Console.WriteLine("Erro, opção inválida");
        //            goto Inicio;
        //        case '+':
        //            resultado = num1 + num2;
        //            Console.WriteLine("O resultado da soma é: " + resultado);
        //            break;
        //        case '-':
        //            resultado = num1 - num2;
        //            Console.WriteLine("O resultado da subtração é: " + resultado);
        //            break;
        //        case 'x':
        //        case 'X':
        //            resultado = num1 * num2;
        //            Console.WriteLine("O resultado da multiplicação é: " + resultado);
        //            break;
        //        case '/':
        //        case ':':
        //            if(num2 == 0)
        //            {
        //                Console.WriteLine("Não é possivel dividir por 0.");
        //            } 
        //            else
        //            {
        //                resultado = num1 / num2;
        //                Console.WriteLine("O resultado da divisão é: " + resultado);
        //             }
        //            break;
        //    }

        //    Console.Write("Continuar calculando (s / n)? ");
        //    string opcao = Console.ReadLine();

        //    if(opcao == "s" || opcao == "S")
        //    {
        //        goto Inicio;
        //    }
        #endregion

        #region Forma Praticada
        Inicio:
            Console.Clear();

        Inicio1:
            double num1 = 0;
            Console.Write("Digite o Primeiro número: ");
            string numero1 = Console.ReadLine();

            bool canConvert1 = double.TryParse(numero1, out num1);
            if (canConvert1 == false)
            {
                Console.Clear();
                Console.WriteLine("Caracter Invalido!");
                goto Inicio1;
            }

        Inicio2:
            double num2 = 0;
            Console.Write("Digite o Segundo número: ");
            string numero2 = Console.ReadLine();

            bool canConvert2 = double.TryParse(numero2, out num2);
            if (canConvert2 == false)
            {
                Console.Clear();
                Console.WriteLine("Caracter Invalido!");
                goto Inicio2;
            }
        OpInv:
            Console.Write("Escolha a operaçao (+ - x /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("Digite o Segundo número: " + num1 + "\n" + "Digite o Segundo número: " + num2);
                    Console.WriteLine("Erro, opção inválida");
                    goto OpInv;
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;
                case 'x':
                case 'X':
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;
                case '/':
                case ':':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    break;
            }

            Console.Write("Continuar calculando (s / n)? ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
            #endregion

            #region Pratica 2
            //Ini:
            //    Console.Clear();

            //    Inicio1:
            //    double numer1 = 0;
            //    Console.Write("Digite o primeiro Numero: ");
            //    string n1 = Console.ReadLine();

            //    bool convert1 = double.TryParse(n1, out numer1);
            //    if (convert1 == false)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Caracter Invalido!");
            //        goto Inicio1;
            //    }

            //    Inicio2:
            //    double numer2 = 0;
            //    Console.Write("Digite o segundo Numero: ");
            //    string n2 = Console.ReadLine();

            //    bool convert2 = double.TryParse(n2, out numer2);
            //    if (convert2 == false)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Caracter Invalido!");
            //        goto Inicio2;
            //    }

            //    TipoConta:
            //    Console.Write("Qual operação será feita? +  -  *  /: ");
            //    char tipo = char.Parse(Console.ReadLine());

            //    switch (tipo)
            //    {
            //        default:
            //            Console.Clear();
            //            Console.WriteLine("Digite o Segundo número: " + numer1 + "\n" + "Digite o Segundo número: " + numer2);
            //            Console.WriteLine("Erro, opção inválida");
            //            goto TipoConta;
            //            break;
            //        case '+':
            //            Console.WriteLine("A soma é: " + (numer1 + numer2));
            //            break;
            //        case '-':
            //            Console.WriteLine("A subtração é: " + (numer1 - numer2));
            //            break;
            //        case '*':
            //        case 'x':
            //        case 'X':
            //            Console.WriteLine("A multiplicação é: " + (numer1 * numer2));
            //            break;
            //        case '/':
            //        case ':':
            //            Console.WriteLine("A divisão é: " + (numer1 / numer2));
            //            break;
            //    }

            //    Console.Write("Quer continuar? (S/N)");
            //    string confi = Console.ReadLine();

            //    if (confi == "s" || confi == "S")
            //    {
            //        goto Ini;
            //    }

            #endregion
        }
    }
}
