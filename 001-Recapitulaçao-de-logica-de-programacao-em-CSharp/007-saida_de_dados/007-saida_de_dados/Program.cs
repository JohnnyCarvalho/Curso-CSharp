using System;

namespace _007_saida_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Para entrada de dados em C# utilizamos o comando
             * Consile.ReadLine();
             * Vejamos os exemplos a seguir:
             */

            String frase = Console.ReadLine();
            String x = Console.ReadLine();
            String y = Console.ReadLine();
            String z = Console.ReadLine();
            
            String[] vet = Console.ReadLine().Split(' ');
            String a = vet[0];
            String b = vet[1];
            String c = vet[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Write(a + " " + b + " " + c);

        }
    }
}
