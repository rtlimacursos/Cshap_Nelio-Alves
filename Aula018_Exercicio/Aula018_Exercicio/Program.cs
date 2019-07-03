using System;
using System.Globalization;

namespace Aula018_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto;
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
                                 
            produto = "Computador";
            preco = 2100.00;
            Console.WriteLine(produto + ", cujo preco é "+ preco.ToString("F2"));

            produto = "Mesa de escritório";
            preco = 650.50;
            Console.WriteLine(produto + ", cujo preco é "+ preco.ToString("F2"));

            Console.WriteLine("Registro:" + idade + " de idade, código " + codigo + " Genero:" + genero);

            Console.WriteLine("Medida de oito casas decimais: " + medida.ToString("F8"));

            Console.WriteLine("Arredonda 3 casa decimais: " + medida.ToString("F3"));

            Console.WriteLine("Separador decimal: "  + medida.ToString("F3",CultureInfo.InvariantCulture));







        }
    }
}
