using System;

namespace CoinToss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 1 Start");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You are now playing Coin Toss!");
            Thread.Sleep(500);
            Console.WriteLine("You may now make your bets. Type HEADS or TAILS");

            string UserInput = Console.ReadLine();
            Random random = new Random();
            int coinToss = random.Next(0, 2);
            Console.WriteLine(coinToss);

            if ((coinToss == 0) && (UserInput == "TAILS"))
            {
                Console.WriteLine("You were correct! The coin shows TAILS");
            }
            else if ((coinToss == 1) && (UserInput == "HEADS"))

            {
                Console.WriteLine("You were correct! The coin shows HEADS");
            }
            else
            {
                Console.WriteLine("You guessed wrong! Try again");
            }
        }
    }
}
