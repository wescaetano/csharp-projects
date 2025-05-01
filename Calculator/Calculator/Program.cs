using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            string decisao;
            Console.Clear();
            do { 
                Console.WriteLine("Qual operação deseja fazer: ");
                Console.WriteLine("1- Adição ");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("5- Sair");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Digite a operação que você deseja fazer:");
                short operacao = short.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        Adicao();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Multiplicacao();
                        break;
                    case 4:
                        Divisao();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Operação inexistente!");
                        Console.ReadLine();
                        Menu();
                        break;
                }

                Console.WriteLine("Deseja repetir a operação: (s/n)");
                decisao = Console.ReadLine();
                if(decisao == "s")
                {
                    Console.Clear();
                }
        } while (decisao == "s");

        }

        static void Adicao()
        {
            double[] num = new double[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número: ");
                num[i] = double.Parse(Console.ReadLine());
            }

            double resultado = num[0] + num[1];
            Console.WriteLine("O resultado da adição é: " + resultado);
        }

        static void Subtracao()
        {
            double[] num = new double[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número: ");
                num[i] = double.Parse(Console.ReadLine());
            }

            double resultado = num[0] - num[1];
            Console.WriteLine("O resultado da subtração é: " + resultado);
        }

        static void Multiplicacao()
        {
            double[] num = new double[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número: ");
                num[i] = double.Parse(Console.ReadLine());
            }

            double resultado = num[0] * num[1];
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
        }

        static void Divisao()
        {
            double[] num = new double[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " número: ");
                num[i] = double.Parse(Console.ReadLine());
            }

            double resultado = num[0] / num[1];
            Console.WriteLine("O resultado da divisão é: " + resultado);
        }
    }
}