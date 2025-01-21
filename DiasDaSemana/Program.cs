using System;

namespace DiasDaSemana
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Qual o dia da semana?");
            int diaDaSemana = Convert.ToInt32(Console.ReadLine());

            if (diaDaSemana == 0)
            {
                Console.WriteLine("Que dia de semana é esse que tu tem? '-'");
            }
            else if (diaDaSemana > 7)
            {
                Console.WriteLine("O seu calendário é muito estranho, tem mais que 7 dias. ");
            }
            else if (diaDaSemana >= 1 && diaDaSemana <= 7)
            {

                switch (diaDaSemana)
                {
                    case 1:
                        Console.WriteLine("Segunda-feira");
                        break;
                    case 2:
                        Console.WriteLine("Terça-feira");
                        break;
                    case 3:
                        Console.WriteLine("Quartaa-feira");
                        break;
                    case 4:
                        Console.WriteLine("Quitna-feira");
                        break;
                    case 5:
                        Console.WriteLine("Sexta-feira");
                        break;
                    case 6:
                        Console.WriteLine("Sábado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                    default:
                        Console.WriteLine("Você precisa informar qual o dia da semana você está!");
                        break;
                }

            }
        }
    }
}

/*
Escrever um programa que peça ao usuário um número 
de 1 a 7 e exiba o dia correspondente da semana.
*/