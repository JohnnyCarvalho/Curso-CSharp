using System;

namespace _004_operadores_de_atribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Operadores de atribuição são necessários não só para fazer cálculos, mais também para
             * atribuir um valor a uma variável, nesses exemplos veremos como atribuir um valor a uma varuiável
             * utilizando o operador += e etc...
             */

            int a = 10;

            int b = 20;

            String c = "ABC";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            a += 10;
            b -= 10;
            c += "DEF";

            Console.WriteLine("Novo valor de a é: "+a);
            Console.WriteLine("Novo valor de b é: " + b);
            Console.WriteLine("Novo valor de c é: " + c);

            // Operador aritmético/atribuição ++ e --, nesse caso a variável será incrementada em +1 ou -1

            int d = 1;
            int e = 1;

            Console.WriteLine(d);
            Console.WriteLine(e);

            d++;
            e--;

            Console.WriteLine("O novo valor de d é: "+d);
            Console.WriteLine("O novo valor de e é: "+e);

            int f = ++d;
            int g = --e;

            Console.WriteLine(f);
            Console.WriteLine(g);

            /*
             * se colocarmos f = d++ o f vai receber o valor original de d e 
             * somente o d sera incrementado em +1.
             * No exemplo acima o f vale 3 e o g vale -1, vejamos o exemplo abaixo colocando o
             * f = d++ e o g = e--, nesse caso ele deveria imprimir f valendo 4 e g valendo -2
             * porém, note que não é isso que vai acontecer.
             */

            f = d++;
            g = e--;

            Console.WriteLine("Valor com o d++: "+f);
            Console.WriteLine("Valor com o e--: "+g);

            f = ++d;
            g = --e;

            Console.WriteLine("Valor com o ++d: "+f);
            Console.WriteLine("Valor com o --e: "+g);


        }
    }
}
