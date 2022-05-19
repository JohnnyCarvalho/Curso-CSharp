using System;
using System.Globalization;

namespace _008_entrada_de_dados_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O valor de n1 é: {n1}");
            Console.WriteLine($"O caractere digitado é: {ch}");
            Console.WriteLine("O valor de n2 é: " + n2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
