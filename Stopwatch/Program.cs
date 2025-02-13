using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] str)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual o tempo deseja contar?");
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplaier = 1;

            if (type == 'm')
                multiplaier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplaier);


            Console.Clear();
            Console.WriteLine($"Você finalizou sua atividade em {time}{type}");
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            // int time = 10;
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(100);
            }

            Console.Clear();
            Console.WriteLine("StopWatch Finaly... return of menu!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}