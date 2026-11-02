
using System;

namespace TaxLibrary
{
    public class TaxCalculator
    {
        // Old Tax Regime
        public double CalculateOldTax(double income)
        {
            double tax = 0;

            if (income > 1000000)
                tax = 12500 + 100000 +
                      (income - 1000000) * 0.30;

            else if (income > 500000)
                tax = 12500 +
                      (income - 500000) * 0.20;

            else if (income > 250000)
                tax = (income - 250000) * 0.05;

            return tax;
        }

        // New Tax Regime (Illustrative slabs)
        public double CalculateNewTax(double income)
        {
            double tax = 0;

            if (income > 2400000)
                tax = 20000 + 40000 + 60000 +
                      80000 + 100000 +
                      120000 + (income - 2400000) * 0.30;

            else if (income > 2000000)
                tax = 20000 + 40000 + 60000 +
                      80000 + 100000 +
                      (income - 2000000) * 0.25;

            else if (income > 1600000)
                tax = 20000 + 40000 + 60000 +
                      80000 + (income - 1600000) * 0.20;

            else if (income > 1200000)
                tax = 20000 + 40000 + 60000 +
                      (income - 1200000) * 0.15;

            else if (income > 800000)
                tax = 20000 + 40000 +
                      (income - 800000) * 0.10;

            else if (income > 400000)
                tax = 20000 +
                      (income - 400000) * 0.05;

            return tax;
        }
    }
}
