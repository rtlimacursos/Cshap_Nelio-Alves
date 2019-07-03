using System;

namespace Aula040_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            Console.WriteLine("Dados da primeira Pessoa");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            p2 = new Pessoa();
            Console.WriteLine("Dados da segunda Pessoa");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if( p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + p2.nome);
            }

        }
    }
}
