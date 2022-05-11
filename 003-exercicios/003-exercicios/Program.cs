using System;
using System.Globalization;

namespace _003_exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String produto1 = "Computador";
            String produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = (preco1 + preco2) / 2;


            // Saída de dados
            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1);
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2);

            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e genero " + genero);

            Console.WriteLine("Média com 8 casas decimais: " + media.ToString("F8"));
            Console.WriteLine("Arredondando para 3 casas decimais: " + media.ToString("F3"));
            Console.WriteLine("Separador de casas decimais InvariantCulture: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
