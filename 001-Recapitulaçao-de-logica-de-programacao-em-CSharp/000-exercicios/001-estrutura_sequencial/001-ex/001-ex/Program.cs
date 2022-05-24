using System;

/*
 * Faça um programa para ler dois valores inteiros, e 
 * depois mostrar na tela a soma desses números com uma
 * mensagem explicativa, conforme exemplos.
 * 
 * Exemplos:

Entrada:              |          Saída:
10                    |          SOMA = 40
30                    |  
                      |  
Entrada:              |          Saída:
-30                   |          SOMA = -20
                      |  
10                    |  
Entrada:              |          Saída:
0                     |          SOMA = 0
0                     |  

 */

namespace _001_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            int num3 = -30;
            int num4 = 10;
            int num5 = 0;
            int num6 = 0;


            int soma1 = num1 + num2;
            int soma2 = num3 + num4;
            int soma3 = num5 + num6;

            Console.WriteLine($"SOMA = {soma1}");
            Console.WriteLine($"SOMA = {soma2}");
            Console.WriteLine($"SOMA = {soma3}");

        }
    }
}
