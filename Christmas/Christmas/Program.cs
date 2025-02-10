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
            DateTime input = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter a date in the format dd-MM-yyyy");
            DateTime daystill = (int)Math.Floor(christmas - input);
            Console.Write("Next christmas is:");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine(christmas.ToString());
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine($"Days till christmas: {daystill}");
        }
    }
}
