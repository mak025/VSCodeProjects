namespace BallAndCups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose the cup in which you believe the ball is under.");
            Console.WriteLine("(Type 1, 2 or 3 and then hit Enter)");
            string UserInput = Console.ReadLine();
            double value = int.Parse(UserInput);

            Random random = new Random();
            double cup = random.Next(1, 3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hiding ball and shuffling the cups");
            Thread.Sleep(2000);

            if ((cup == 1) && (value == 1))
            {
                Console.WriteLine("You found the cup. Well done!");
            }
            else if ((cup == 2) && (value == 2))
            {
                Console.WriteLine("You found the cup. Well done!");
            }
            else if ((cup == 3) && (value == 3))
            {
                Console.WriteLine("You found the cup. Well done!");
            }
            else
            {
                Console.WriteLine("Wrong. Try again");
            }
        }   
    }
}
