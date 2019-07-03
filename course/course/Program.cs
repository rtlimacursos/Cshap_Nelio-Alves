using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2}", nome, idade,saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2",CultureInfo.InvariantCulture));
            */

            //Aula 22
            /*string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split('-');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Vc digitou");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.Write(a + " " + b + " " + c);
            */

            //aula 23
            /* int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Vc digitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F3",CultureInfo.InvariantCulture));
            */

            //aula 30
            /*Console.WriteLine("Digite tres numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior: " + resultado);
        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
            */

            //aula 32
            /*Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());
            while (x > 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3",CultureInfo.InstalledUICulture));
                Console.WriteLine("Digite um numero: ");
                x = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Numero Negativo");
            */
            //Aula 34
            /*
            Console.Write("Informe qtos numeros vc vai digitar");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1;i <=N;i++)
            {
                Console.Write("Valor: #{0}",i);
                int Valor = int.Parse(Console.ReadLine());
                soma += Valor;
                
            }
            Console.WriteLine("Soma:" + soma);
            */

            //Aula 38
            /*double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - xC));


            Console.WriteLine("Area de X: " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area X");
            }
            else
            {
                Console.WriteLine("Maior area Y");
            }
            */
            //Aula 39
            /*Triangulo x, y;

            x = new Triangulo();

            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - x.C));


            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area X");
            }
            else
            {
                Console.WriteLine("Maior area Y");
            }
            */
            //Aula 41
            Triangulo x, y;

            x = new Triangulo();

            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = y.Area();


            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area X");
            }
            else
            {
                Console.WriteLine("Maior area Y");
            }

        }

    }
}
