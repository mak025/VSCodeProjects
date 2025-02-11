namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 2 Start");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Dice roll will now begin");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dice is rolling...");
            Thread.Sleep(1500);
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.ForegroundColor = ConsoleColor.Blue;

            if (dice == 1)
            {
                Console.WriteLine("You rolled a 1");
            }
            else if (dice == 2)
            {
                Console.WriteLine("You rolled a 2");
            }
            else if (dice == 3)
            {
                Console.WriteLine("You rolled a 3");
            }
            else if (dice == 4)
            {
                Console.WriteLine("You rolled a 4");
            }
            else if (dice == 5)
            {
                Console.WriteLine("You rolled a 5");
            }
            else
            {
            Console.WriteLine("You rolled a 6");
            }
        }
    }
}
