using System;

namespace Calculadora
{
    class Program
    {

        static void Main(string[] str)
        {
            //string[] operador = new string[4] { "+", "-", "*", "/" };
            /*
            operador
            numerador
            denominador

            Criar uma calculadora que execute operações básicas com base em uma entrada do usuário.
            Solicite ao usuário dois números.
            Peça ao usuário que escolha uma operação: +, -, *, ou /.
            Use um bloco switch para realizar a operação escolhida e exibir o resultado.
            Trate casos inválidos, como divisões por zero ou operações desconhecidas.

            Digite o primeiro número: 10
            Digite o segundo número: 5
            Escolha uma operação (+, -, *, /): 
            O resultado é: 50

            */
            int numeradorInput = 0, denominadorInput = 0, resultado = 0;
            string operacao = "";
            string[] simbolos = { "+", "-", "*", "/" };
            //operacao
            Console.WriteLine("Digite que tipo de operação será realizada: ");
            operacao = Console.ReadLine();
            if (operacao == "")
            {
                Console.WriteLine("Não conseguimos seguir sem saber como devemos trabalhar.");
            }
            // else if (operacao != simbolos[4])
            // {
            //     Console.WriteLine("Você precisa informar uma operação!");
            // }
            else
            {
                //numerador
                Console.WriteLine("Qual o numerador: ");
                numeradorInput = int.Parse(Console.ReadLine());
                //denominador
                Console.WriteLine("Qual o denominador: ");
                denominadorInput = int.Parse(Console.ReadLine());


                //execução da operação conforme definido pelo usuário por meio do chat.
                if (operacao == "+")
                {
                    resultado = numeradorInput + denominadorInput;
                    Console.WriteLine($"Somandos :{resultado}");
                }
                else if (operacao == "-")
                {
                    resultado = numeradorInput - denominadorInput;
                    Console.WriteLine($"Subtraido :{resultado}");
                }
                else if (operacao == "*")
                {
                    resultado = numeradorInput * denominadorInput;
                    Console.WriteLine($"Multiplicado :{resultado}");
                }
                else if (operacao == "/")
                {
                    resultado = numeradorInput / denominadorInput;
                    Console.WriteLine($"Dividido :{resultado}");
                }
                else
                {
                    Console.WriteLine("Fail!");
                }

            }
        }
    }
}



