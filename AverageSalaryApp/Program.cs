using AverageSalaryApp.Class;
using System;
using System.Globalization;

namespace AverageSalaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People p = new People();
            People p1 = new People();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Salario: ");
            p.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo funcionário:");
            Console.WriteLine("Nome: ");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Salario: ");
            p1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (p.Salary + p1.Salary) / 2.0;

            Console.WriteLine("Salário Médio " + media.ToString("F2", CultureInfo.InvariantCulture));

            

        }
    }
}
