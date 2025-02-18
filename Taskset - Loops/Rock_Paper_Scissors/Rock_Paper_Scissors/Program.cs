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

            Random random = new Random();
            int color = random.Next(1, 3);

            string selectedHand = "";

            switch (color)
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

            int userAttempts = 1;
            for (int i = 0; i < userAttempts; i++)
            {
                Console.Write("Type your choice here: ");
                string input = Console.ReadLine();
                Console.Write("Rock, ");
                Thread.Sleep(1000);
                Console.Write("Paper, ");
                Thread.Sleep(1000);
                Console.Write("Scissors");
                Thread.Sleep(1000);


                if (selectedHand == input)
                {
                    Console.WriteLine("Correct! Sloppy High-Five granted!");
                    i = userAttempts + 1;

                }
                else
                {
                    Console.WriteLine("Wrong. Not sloppy High-Five for you!");

                    if (i == userAttempts - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry {selectedHand} won");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
