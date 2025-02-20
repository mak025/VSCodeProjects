using System.Diagnostics;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rock, Paper, Scissors! Choose your hand!");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);

            string Rock = "Rock";
            string Paper = "Paper";
            string Scissors = "Scissors";

            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (; timer.Elapsed.TotalSeconds < 15;)
            {

                Random random = new Random();
                int hand = random.Next(1, 4);

                string selectedHand = "";

                switch (hand)
                {
                    case 1:
                        selectedHand = Rock;
                        break;
                    case 2:
                        selectedHand = Paper;
                        break;
                    case 3:
                        selectedHand = Scissors;
                        break;
                }
                Console.Write("Type your choice here: ");
                string input = Console.ReadLine();
                Console.Write("Rock, ");
                Thread.Sleep(500);
                Console.Write("Paper, ");
                Thread.Sleep(500);
                Console.WriteLine("Scissors");
                Thread.Sleep(500);


                if (selectedHand == Rock && input == "Paper" || selectedHand == Paper && input == "Scissors" || selectedHand == Scissors && input == "Rock")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct! Sloppy High-Five granted!");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (selectedHand == input)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Draw! Try again!");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry {selectedHand} won");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
