using System;

/*
 * Fazer um programa para ler o código de uma peça 1, o número de peças 1, 
 * o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 
 * 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
 * 
 * 
 * Exemplos:

Entrada:              |          Saída:
25 1 5.30             |          
16 2 5.10             |          VALOR A PAGAR: U$ 15.50
                      |  
Entrada:              |          Saída:
13 2 15.30            |          
161 4 5.20            |          VALOR A PAGAR: U$ 51.40
                      |  
Entrada:              |          Saída:
1 1 15.10             |          
2 1 15.10             |          VALOR A PAGAR = U$ 30.20
 
 */

namespace _005_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** DIGITE ABAIXO OS DADOS DA PEÇA SELECIONADA ***");
            Console.WriteLine("Digite os dados em uma única linha seguindo a sequência\n" +
                "CÓDIGO  QUANTIDADE  PREÇO UNITÁRIO");

            String[] vet = Console.ReadLine().Split(' ');
            

        }
    }
}
