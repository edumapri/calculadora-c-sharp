using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
        static void Main(string[] args)
        {
            bool finalizarMenu = false;
            while (!finalizarMenu) // Enquanto não (!) for selecionado sair pelo usuário o menu será apresentado
            {
                Console.WriteLine("#######################################################");
                Console.WriteLine("#                                                     #");
                Console.WriteLine("# Calculadora básica, selecione uma das opções abaixo #");
                Console.WriteLine("#                                                     #");
                Console.WriteLine("#######################################################\n");


                Console.WriteLine("1-Soma");
                Console.WriteLine("2-Subtração");
                Console.WriteLine("3-Divisão");
                Console.WriteLine("4-Multiplicação");
                Console.WriteLine("5-Potência");
                Console.WriteLine("6-Raiz quadrada");
                Console.WriteLine("7-Sair");

                string opcaoUser = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoUser);
                Menu opcao = (Menu)opcaoInt;

                /* Menu opcao = (Menu)int.Parse(Console.ReadLine()); */

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        finalizarMenu = true;
                        break;
                }

                Console.Clear();
            }

            
        }

        static void Soma()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Soma entre dois números: ");
            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a + b;
            Console.WriteLine("\nO resultado da soma é: " + resultado);
            Console.WriteLine("\nPressione <ENTER> para retornar ao menu");
            Console.ReadLine();
        }
  
        static void Subtracao()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Subtração entre dois números: ");
            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a - b;
            Console.WriteLine("\nO resultado da subtração é: " + resultado);
            Console.WriteLine("\nPressione <ENTER> para retornar ao menu");
            Console.ReadLine();
        }
 
        static void Divisao()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Divisão entre dois números: ");
            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine("\nO resultado da divisão é: " + resultado);
            Console.WriteLine("\nPressione <ENTER> para retornar ao menu");
            Console.ReadLine();
        }

        static void Multiplicao()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Multiplicação entre dois números: ");
            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine("\nO resultado da multiplicação é: " + resultado);
            Console.WriteLine("\nPressione <ENTER> para retornar ao menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Potência de um número: ");
            Console.Write("Digite a base: ");
            double baseN = double.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expoN = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseN, expoN);
            Console.WriteLine("\nO resultado da potência é: " + resultado);
            Console.WriteLine("\nPressione <ENTER> para retornar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Raiz de um número: ");
            Console.Write("Digite o número: ");
            double raizN = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(raizN);
            Console.WriteLine("\nO resultado da raiz quadrada é: " + resultado);
            Console.WriteLine("\nPressione <ENTER> para retornar ao menu");
            Console.ReadLine();
        }
    }
}