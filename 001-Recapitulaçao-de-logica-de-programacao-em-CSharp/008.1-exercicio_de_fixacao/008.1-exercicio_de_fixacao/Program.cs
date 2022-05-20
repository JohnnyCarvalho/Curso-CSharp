using System;
using System.Globalization;

namespace _008._1_exercicio_de_fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fazer um programa que receba os dados do usuário armazene os mesmo em variáveis
             * e na sequência imprima na tela os dados armazenados dentro de cada variável.
             */

            Console.WriteLine("What's your complete name?");
            String completeName = Console.ReadLine();

            Console.WriteLine("How many roons do you have in your house?");
            int roons = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter with product price:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter with your last name, weight and height (write on same line)");
            String[] vet = Console.ReadLine().Split(' ');
            String lastName = vet[0];
            int weight = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // Saída de dados

            Console.WriteLine($"Your complete name is: {completeName}.");
            Console.WriteLine($"Your house has {roons} roons.");
            Console.WriteLine("The value of product is: "+price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Yous last name is {lastName}, your years old is {weight} and yous height is "+
                height.ToString("F2", CultureInfo.InvariantCulture));


            

        }
    }
}
