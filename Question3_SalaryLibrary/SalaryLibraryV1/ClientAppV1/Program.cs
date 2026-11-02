
using System;
using SalaryLibrary;

namespace ClientAppV1
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator obj = new SalaryCalculator();

            double salary = 30000;

            Console.WriteLine("Salary Calculation - Version 1.0");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Basic Salary: " +
                obj.CalculateBasicSalary(salary));

            Console.ReadLine();
        }
    }
}
