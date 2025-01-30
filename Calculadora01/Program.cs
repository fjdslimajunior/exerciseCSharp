using System;

namespace Calculadora01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Multiplicação");
            Console.WriteLine("2 - Divisão");
            Console.WriteLine("3 - Soma");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5     - Sair");

            Console.WriteLine("=========================");
            Console.WriteLine("Selecione uma das opçãoes: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Multiplicacao(); break;
                case 2: Divisao(); break;
                case 3: Soma(); break;
                case 4: Subtracao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

            //fim
            Console.ReadKey();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            // Console.WriteLine(v1);
            // Console.WriteLine(v2);
            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação: {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão: {resultado}");
            Console.ReadKey();

            Menu();
        }


    }
}