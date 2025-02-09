namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 7 Start");
            Thread.Sleep(1000);
            Console.ForegroundColor= ConsoleColor.White;
            DateTime birthday = DateTime.ParseExact(readin, "ddMMyyyy", null);
            Console.WriteLine($"{birthday}");
        }
    }
}
