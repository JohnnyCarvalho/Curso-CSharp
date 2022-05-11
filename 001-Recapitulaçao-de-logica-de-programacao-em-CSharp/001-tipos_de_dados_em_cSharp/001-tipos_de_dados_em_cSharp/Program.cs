using System;

namespace _001_tipos_de_dados_em_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abaixo vemos como declarar variáveis e como atribuir valores a elas.
            bool estaChovendo = true;
            char letra = 'A';// quando usamos o char é necessário colocar aspas simples.
            char letra2 = '\u0041';// Essa é uma forma de declarar uma letra em formato unicode.
            sbyte n1 = -128;
            byte n2 = 255;
            short n3 = -32768;
            ushort n4 = 65535;
            int n5 = -2147483648;
            uint n6 = 4294967295;
            long n7 = -9223372036854775808;
            ulong n8 = 18446744073709551615;
            float n9 = 3.14f;
            double n10 = 3.14;
            string nome = "João"; // quando usamos string é necessário colocar aspas duplas.
            object obj1 = "Johnny";
            object obj2 = 3.14;
            int n11 = int.MinValue;// Esse é o valor mínimo de um inteiro.
            int n12 = int.MaxValue;// Esse é o valor máximo de um inteiro.
            double n13 = double.MinValue;// nesse caso imprimimos o valor mínimo de um double.
            double n14 = double.MaxValue; // nesse caso imprimimos o valor máximo de um double.
            decimal n15 = decimal.MinValue;// nesse caso imprimimos o valor mínimo de um decimal.
            decimal n16 = decimal.MaxValue;// nesse caso imprimimos o valor máximo de um decimal.


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(estaChovendo);
            Console.WriteLine(letra);
            Console.WriteLine(letra2);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n11);
            Console.WriteLine(n12);
            Console.WriteLine(n13);
            Console.WriteLine(n14);
            Console.WriteLine(n15);
            Console.WriteLine(n16);
            
            Console.WriteLine();
            

        }
    }
}
