using System;

namespace _005_conversao_implicita_e_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Conversão implicita entre tipos é quando uma variável é de um tipo e você coloca 
             * um valor de outro tipo para que o valor seja convertido para o tipo da variável.
             * Já o casting é quando você faz a conversão explicita entre tipos compatíveis.
             * vejamos os exempos a seguir:
             */

            // Conversão implicita
            float a = 4.5f;
            double b = a;

            Console.WriteLine("Essa operação é possível, pois float tem 4 bytes, e double tem 8 bytes," +
                "\nou seja cabe tranquilamente u float dentro de um double");
            Console.WriteLine("Resultado: "+b);

            // Conversão explícita
            Console.WriteLine("\nO contrário do exemplo acima, será que é possível?" +
                "\nA resposta é sim, nesse caso temos que fazer um conversão explícita utilizando" +
                "\no casting, basta colocar montar a variável assim a = (float)b;");

            a = (float)b;
            Console.WriteLine("Resultado: "+a);

            Console.WriteLine("\nVeremos agora oque acontece quando convertemos um número quebrado" +
                "\npor um número inteiro, nesse caso há perda de dados, veja");

            float c = 5.6f;
            int d = (int)c;
            Console.WriteLine("Resultado: "+d);

            Console.WriteLine("\nE se quisermos o resultado de 2 números inteiros, como faremos?");

            int e = 5;
            int f = 2;

            float resultado = e / f;

            Console.WriteLine("Resultado sem o uso do casting: "+resultado);

            float resultado2 = (float)e / f;

            Console.WriteLine("Resultado da forma correta utilizando o casting: "+resultado2);
        }
    }
}
