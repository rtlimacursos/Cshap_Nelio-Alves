using System;
using System.Globalization;

namespace Aula024_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros");
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            double resultado;
            Console.WriteLine("Informe o sinal da operacao");
            string sinal = Console.ReadLine();
            if (sinal == "+")
            {
                resultado = n1 + n2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (sinal == "-")
            {
                resultado = n1 - n2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else if (sinal == "*")
            {
                resultado = n1 * n2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                resultado = n1 / n2;
                Console.WriteLine("Resultado: " + resultado.ToString("F2"),CultureInfo.InstalledUICulture);

            }




        }
    }
}
