using System;

/*
 * Fazer um programa para ler quatro valores inteiros A, B, C e D. 
 * A seguir, calcule e mostre a diferença do produto
 * de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
 * 
 * Exemplos:

Entrada:              |       Saída:
5                     |       DIFERENÇA = -26
6                     |  
7                     |
8                     |                  
Entrada:______________|_______Saída:__________
5                     |       DIFERENÇA = 86
6                     |  
-7                    |  
8                     |         

  

 */

namespace _003_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);

            int diferenca = a*b - d*c;

            Console.WriteLine("DIFERENÇA = "+diferenca);

        }
    }
}
