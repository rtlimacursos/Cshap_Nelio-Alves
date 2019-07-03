using System;
using System.Globalization;
namespace Aula042
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do Produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
                        Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quantidade);
            Produto p = new Produto(nome, preco);
            Console.WriteLine("Dados atualizados: " + p);
            p.setNome("TESTE set");
            Console.WriteLine("nome get" + p.getNome());
            Console.WriteLine("");
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque");

            int qtde = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removidos do estoque");
            qtde = int.Parse(Console.ReadLine());

            p.RemoveProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
