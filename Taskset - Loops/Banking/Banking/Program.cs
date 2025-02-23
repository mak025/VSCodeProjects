using System;
using System.Threading;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value you wish to deposit:");
            double value = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the interest rate (as a percentage, e.g., 5 for 5%):");
            double interest = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of years for the calculation:");
            int years = int.Parse(Console.ReadLine());

            double rate = interest / 100; // Convert percentage to decimal

            for (int i = 1; i <= years; i++) // Start from year 1
            {
                value += value * rate; // Apply interest (compounded yearly)
                Console.WriteLine($"Year {i}: {value:F2}"); // Display with 2 decimal places
                Thread.Sleep(200);
            }
        }
    }
}
