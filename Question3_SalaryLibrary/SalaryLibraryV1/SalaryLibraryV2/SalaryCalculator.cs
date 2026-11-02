
using System;

namespace SalaryLibrary
{
    public class SalaryCalculator
    {
        // Version 1.0 method
        public double CalculateBasicSalary(double salary)
        {
            return salary;
        }

        // Version 2.0 additional method
        public double CalculateAllowances(double salary)
        {
            double hra = salary * 0.20;
            double da = salary * 0.10;

            return hra + da;
        }
    }
}
