namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 7 Start");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter the birthday of the person you are assisting in the format: dd-MM-yyyy");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            TimeSpan difference = DateTime.Now - birthday;
            int years = (int)Math.Floor(difference.TotalDays / 365.2425);
            int days = (int)Math.Floor(difference.TotalDays);
            birthday = birthday.AddYears(years);
            difference = DateTime.Now - birthday;
            Console.WriteLine($"The customer is {years} + years old and {days}");
            //Console.WriteLine(years);

        }
    }
}
