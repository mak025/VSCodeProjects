namespace StepCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 4 Start

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 4 Start");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Tast det antal skridt du har gået");
            double skridt = double.Parse(Console.ReadLine());
            double meter = (skridt * 0.762);
            double km = (meter / 1000);
            Console.WriteLine($"Du har gået {skridt} skridt, hvilket svarer til {meter} meter eller {km} km");
            //Task 4 End
        }
    }
}
