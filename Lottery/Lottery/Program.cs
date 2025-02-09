namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Change text color to yellow and print Task # start
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 6 Start");
            Thread.Sleep(2000);

            Console.WriteLine("Lotto trækning starter..");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2000);
            //The random class specified here is used to generate a random number
            Random random = new Random();
            //Below codes specifies that the variable randomNumber holds the data "random number between 1 and 100" and will throw a random number between 1 and 100 whenever called
            int randomNumber1 = random.Next(1, 100);
            int randomNumber2 = random.Next(1, 100);
            int randomNumber3 = random.Next(1, 100);
            int randomNumber4 = random.Next(1, 100);
            int randomNumber5 = random.Next(1, 100);
            int randomNumber6 = random.Next(1, 100);
            int jokerNumber = random.Next(1, 100);
            Console.Write($"{randomNumber1} + ");
            Thread.Sleep(2000);
            Console.Write($"{randomNumber2} + ");
            Thread.Sleep(2000);
            Console.Write($"{randomNumber3} + ");
            Thread.Sleep(2000);
            Console.Write($"{randomNumber4} + ");
            Thread.Sleep(2000);
            Console.Write($"{randomNumber5} + ");
            Thread.Sleep(2000);
            Console.Write($"{randomNumber6} ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("And now for the joker number.. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(2000);
            Console.Write($"{jokerNumber}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Congratulations to whoever has the numbers:");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write($"{randomNumber1} + {randomNumber2} + {randomNumber3} + {randomNumber4} + {randomNumber5} + {randomNumber6} + ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{jokerNumber}");
            Console.ForegroundColor = ConsoleColor.Yellow;

        }
    }
}
