namespace CelsiusConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Task 3 Start

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 3 Start");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is a Celcius to Fahrenheit and Raemur converter");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type a value in Celcius");
            double cel = double.Parse(Console.ReadLine());
            double fahrenheit = (cel * 1.8) + 32;
            double raemur = (cel * 0.8);
            Console.WriteLine($"{cel} is the equivalent to {fahrenheit} Fahrenheit and {raemur} raemur");
            //Task 3 End
        }
    }
}
