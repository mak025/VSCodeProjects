namespace GuessTheColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Guess the color within three guesses to win a sloppy high-five");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);

            string cRed = "Red";
            string cBlue = "Blue";
            string cYellow = "Yellow";
            string cGreen = "Green";
            string cPurple = "Purple";

            Random random = new Random();
            int color = random.Next(1, 6);

            string selectedColor = "";

            switch (color)
            {
                case 1:
                    selectedColor = cRed;
                    break;
                case 2:
                    selectedColor = cBlue;
                    break;
                case 3:
                    selectedColor = cYellow;
                    break;
                case 4:
                    selectedColor = cGreen;
                    break;
                case 5:
                    selectedColor = cPurple;
                    break;
            }

            int userAttempts = 3;
            for (int i = 0; i < userAttempts; i++)
            {
                Console.Write("Guess one of the following colors: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Red");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Blue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Yellow");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Green");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" or ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Purple");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();


                if (selectedColor == input)
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
                        Console.WriteLine($"The correct color was {selectedColor}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

        }
    }
}
