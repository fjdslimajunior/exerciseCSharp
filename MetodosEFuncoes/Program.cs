using System;

namespace MetodosEFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            string nome = "";
            Console.WriteLine("Qual a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("E o seu nome : ");
            nome = Console.ReadLine();

            MeuMetodo();
            DadosBase(idade, nome);
        }

        //metodo1
        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!");
        }

        //metodo2
        static void DadosBase(int idade, string nome)
        {

            Console.WriteLine($"Que legal \nSou {nome} e tenho {idade} anos");
        }
    }
}