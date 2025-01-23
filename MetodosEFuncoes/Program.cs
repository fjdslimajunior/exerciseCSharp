using System;

namespace MetodosEFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametros e atributos
            int idade = 0;
            string nome = "", frase = "", conselho = "";
            Console.Clear();
            Console.WriteLine("Qual a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("E o seu nome : ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual é a frase do dia: ");
            frase = Console.ReadLine();

            //metodos
            MeuMetodo();
            DadosBase(idade, nome);

            conselho = MinhaFrase(nome: nome, frase: frase);
            Console.WriteLine(conselho);

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

        static string MinhaFrase(string frase, string nome)
        {
            return frase + " " + nome;
        }
    }
}