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

            Console.WriteLine("\nAgora veremos a segunda parte do projeto de hoje:");

            String[] vet = Console.ReadLine().Split(' ');
            String nome = vet[0];
            Char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            Double peso = double.Parse(vet[3], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Nome: "+nome+"; Sexo: "+sexo+"; Idade: "+idade+"; Peso: "+peso.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
