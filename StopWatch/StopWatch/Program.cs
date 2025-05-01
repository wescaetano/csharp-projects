using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("---Cronometro---");
            Console.WriteLine("S = Segundo -> 10s = 10 segundos");
            Console.WriteLine("M = Minuto -> 10m = 10 minutos");
            Console.WriteLine("0 = Sair");
            Console.Write("Quanto tempo deseja cronometrar: ");
            string data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            switch (type)
            {
                case 's':
                    if (time == 0) { 
                        System.Environment.Exit(0);
                    }
                    PreStart(time);
                    break;
                case 'm':
                    if (time == 0)
                    {
                        System.Environment.Exit(0);
                    }
                    int timeInMinutes = time * 60;
                    PreStart(timeInMinutes);
                    break;
                default:
                    Console.WriteLine("Tipo inexistente!");
                    break;
            }

        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (time != currentTime)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time);
        }

       
    } 
}