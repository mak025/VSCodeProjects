using System;

namespace CoinToss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 1 Start");
            Console.ForegroundColor= ConsoleColor.White;
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You are now playing Coin Toss!");
            Thread.Sleep(500);
            Console.WriteLine("You may now make your bets. Type PLAT or KRONE");
            
            Random random = new Random();
            int coinToss = random.Next(0, 2);
            Console.WriteLine(coinToss);

            if (coinToss < 0) {
                Console.WriteLine("was not 1?");
            } 
            else
            { Console.WriteLine("was 1");
            }

        }
    }
}
