namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature of your freezer");
            string userInput = Console.ReadLine();
            double value = double.Parse(userInput);
            Thread.Sleep(1000);

            if (value == 0)
            {
                Console.WriteLine("The temperature is at the freezing point = 0°");
            }
            else if (value < 0)
            {
                Console.WriteLine("The temperature is in the negatives!");
            }
            else if (value > 0)
            {
                Console.WriteLine("The temperature is in the positives and above freezing point");
            }
        }
    }
}
