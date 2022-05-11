using System;
using System.Globalization;

namespace _002_saidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Good morning!");// sem quebra de linha
            Console.WriteLine("Good afternoon!");// com quebra de linha
            Console.WriteLine("Good night!");// com quebra de linha

            double x = 3.14159;
            Console.WriteLine(x.ToString("F2"));// ToString("F2") -> 2 casas decimais

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));// nesse caso o ponto é o separador decimal e não mais a vírgula.

            // vamos ver alguns exemplos de junção de strings em C#

            string nome = "João";
            int idade = 20;
            double saldo = 10.35;

            // placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2}", nome, idade, saldo);

            // interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}");

            // concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
