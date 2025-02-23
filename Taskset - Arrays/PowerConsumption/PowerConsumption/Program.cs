﻿namespace PowerConsumption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double[] consumption = 
                {
                1.25, 2.4, 1.96, 1.7, 0.81, 0.81, 0.62, 2.23,
                1.7, 1.92, 0.54, 2.44, 2.16, 0.92, 0.86, 0.87,
                1.11, 1.55, 1.36, 1.08, 1.72, 0.78, 1.08, 1.23
                };
            double[] pricePerKWh = 
                {
                3.41, 4.07, 2.9, 3.53, 3.68, 2.59, 3.72, 2.84, 2.63, 4.4,
                4.43, 4.12, 3.11, 2.7, 3.87, 3.38, 2.74, 3.49, 2.57, 4.32,
                3.02, 3.83, 3.12, 3.54
                };
            double[] costPerHour = new double[24];
            for (int i = 0;i < 24; i++)
            {
                costPerHour[i] = consumption[i] * pricePerKWh[i];
                Console.WriteLine($"Hour {i}: {consumption[i]}kwh, {pricePerKWh[i]} DKK/kwh");
            }
            Console.WriteLine("Do you want the total cost of power consumption for today?");
            string querry = Console.ReadLine();
            if (querry == "yes")
            {
                double sum = costPerHour.Sum();
                Console.WriteLine($"The total cost of consumtion is {sum}");
            }
            else
            {
                Console.WriteLine("Alright. Have a good day!");
            }

        }
    }
}
