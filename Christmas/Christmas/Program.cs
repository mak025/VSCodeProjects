namespace Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 8 Start");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);

            DateTime christmas = new DateTime(2025, 12, 24);

            Console.WriteLine("Enter a date in the format dd-MM-yyyy");
            DateTime input = DateTime.Parse(Console.ReadLine());
            double daysUntilChristmas = christmas.Subtract(input).TotalDays;
            Thread.Sleep(1000);
            Console.Write("Next christmas is: 24-12-2025. There are ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{daysUntilChristmas}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" days left till Christmas");
        }
    }
}
