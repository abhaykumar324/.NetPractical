
using System;
using SalaryLibrary;

namespace ClientAppV2
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator obj = new SalaryCalculator();

            double salary = 30000;

            double basic = obj.CalculateBasicSalary(salary);
            double allowances = obj.CalculateAllowances(salary);

            Console.WriteLine("Salary Calculation - Version 2.0");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Basic Salary: " + basic);
            Console.WriteLine("Allowances: " + allowances);
            Console.WriteLine("Total Salary: " + (basic + allowances));

            Console.ReadLine();
        }
    }
}


/*Advantages of Assembly Versioning
1. Backward Compatibility: Older applications can continue using older library versions.
2. New Features: New versions can introduce additional methods.
3. Version Control: Different assembly versions can be identified.
4. Easy Maintenance: Updates can be managed without unnecessarily changing every client application.
5. Side-by-Side Execution: .NET Framework supports multiple strongly named assembly versions.*/