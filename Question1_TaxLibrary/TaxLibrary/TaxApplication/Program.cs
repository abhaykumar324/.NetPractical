
using System;
using TaxLibrary;

class Program
{
    static void Main()
    {
        TaxCalculator obj = new TaxCalculator();

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Annual Income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        double oldTax = obj.CalculateOldTax(income);
        double newTax = obj.CalculateNewTax(income);

        Console.WriteLine("\n--- Employee Tax Details ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Annual Income: " + income);
        Console.WriteLine("Old Regime Tax: " + oldTax);
        Console.WriteLine("New Regime Tax: " + newTax);
    }
}



/*
 Advantages of Using Assembly Instead of Duplicating Code
1. Code Reusability: The same DLL can be used in multiple applications.
2. Maintainability: Changes in tax calculation logic can be made in one place.
3. Reduced Code Duplication: No need to write the same code repeatedly.
4. Easy Deployment: Compiled DLL can be distributed and referenced by other applications.
5. Modularity: Application logic and tax calculation logic remain separate.
6. Better Testing: The tax calculation class can be tested independently.
7. Security of Implementation: Users of the DLL can access its public methods without needing the original source code.
 
 
 */
