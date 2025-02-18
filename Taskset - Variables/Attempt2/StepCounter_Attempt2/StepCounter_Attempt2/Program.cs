namespace StepCounter_Attempt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a step-count converter. Please enter the amount of steps you've walked to get the distance in km");
            double steps = double.Parse(Console.ReadLine());
            double m = (steps * 0.762);
            double km = (m / 1000);

            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine($"{steps} is roughly {m} which is rougly {km}");
        }
    }
}
