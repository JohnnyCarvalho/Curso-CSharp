using System;
using System.Globalization;

namespace _006_operadores_arotmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vamos relembrar agora algumas regrinhas sobre preterição entre operadores aritméticos
             * no momento que fazemos uma operação.
             */

            int n1 = 10 + 10 * 2;
            int n2 = (10 + 10) * 2;
            int n3 = 9 % 2;
            double n4 = (double)10 / 3;


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4.ToString("F2", CultureInfo.InvariantCulture));

            // agora vamos fazer um cálculo utilizando a fórmula de baskara
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("O resultado da primeira raiz da equação é: " + x1);
            Console.WriteLine("O resultado da segunda raiz da equação é: " + x2);
        }
    }
}
