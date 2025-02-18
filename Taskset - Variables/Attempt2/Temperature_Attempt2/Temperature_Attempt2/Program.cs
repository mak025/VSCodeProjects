namespace Temperature_Attempt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a temperature converter");
            Console.WriteLine("Enter a temperature in Celsius.");

            double celsius = double.Parse(Console.ReadLine());
            double Fahrenheit = (celsius * 1.8) + 32;
            double Raemur = (celsius * 0.8);

            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine($"{celsius} in Fahrenheit is {Fahrenheit} and in Raemur it is {Raemur}");
        }
    }
}
