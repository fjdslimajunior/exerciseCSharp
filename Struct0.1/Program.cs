using System;

namespace Struct01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um produto
            Product produto = new Product(100, "Notebook", 299.9f);

            // Exibindo os dados do produto
            Console.WriteLine("ID: " + produto.Id);
            Console.WriteLine("Nome: " + produto.Name);
            Console.WriteLine("Preço em BRL: R$" + produto.Price);

            // Calculando o preço em dólares
            double taxaDolar = 4.9; // Exemplo: taxa de câmbio é 4.9
            double precoEmDolar = produto.PriceInDolar(taxaDolar);
            Console.WriteLine("Preço em US: $" + precoEmDolar);
        }
    }
    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public int Id;
        public double Price;
        public string Name;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
        public double MelhorValor()
        {

        }

    }
}