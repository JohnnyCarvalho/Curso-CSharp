using System;
using System.Globalization;

/*
 * Fazer um programa que leia o número de um funcionário, 
 * seu número de horas trabalhadas, o valor que recebe por
 * hora e calcula o salário desse funcionário. A seguir, mostre 
 * o número e o salário do funcionário, com duas casas decimais.
 * 
 * Exemplos:

Entrada:              |          Saída:
25                    |          NUMBER = 25
100                   |          SALARY = U$ 550.00
5.50                  |  
Entrada:              |          Saída:
1                     |          SOMA = 1
200                   |          SALARY = U$ 4100.00
20.5                  |  
Entrada:              |          Saída:
6                     |          SOMA = 6
145                   |          SALARY = U$ 2254.75
15.55                 |
 */

namespace _004_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Digite os dados dos funcionários abaixo ***");

            Console.Write("Digite o número do funcionário: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas: ");
            Double hoursWork = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite quantos você recebe por hora trabalhado: ");
            Double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hoursWork * pricePerHour;

            // DATA OUTPUT

            Console.WriteLine($"Number = {number}");
            Console.WriteLine("Salary = "+salary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
