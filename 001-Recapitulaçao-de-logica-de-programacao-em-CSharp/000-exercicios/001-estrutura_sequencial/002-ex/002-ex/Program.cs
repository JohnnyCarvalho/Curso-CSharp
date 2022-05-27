using System;
using System.Globalization;

/*
 * Faça um programa para ler o valor do raio de um círculo, 
 * e depois mostrar o valor da área deste círculo com quatro
 * casas decimais conforme exemplos.
 * Fórmula da área: area = π . raio2
 * Considere o valor de π = 3.14159
 * 
 * Exemplos:

Entrada:              |     Saída:
2.0                   |     A = 12.5664
                      |  
                      |  
Entrada:              |     Saída:
100.64                |     A = 31819.3103
                      |  
                      |  
Entrada:              |     Saída:
150.00                |     A = 70685.7750
                      |  

 */

namespace _002_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double pi = 3.14159;

            Double raio1 = 2.0;
            Double raio2 = 100.64;
            Double raio3 = 150.00;

            Double area1 = Math.Pow(raio1, 2) * pi;
            Double area2 = Math.Pow(raio2, 2) * pi;
            Double area3 = Math.Pow(raio3, 2) * pi;

            Console.WriteLine("Area 1 = "+area1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area 2 = " + area2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area 3 = "+area3.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}
