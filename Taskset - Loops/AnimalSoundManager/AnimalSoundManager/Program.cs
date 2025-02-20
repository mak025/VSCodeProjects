using System;
using System.Media;

namespace AnimalSoundManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hello, This is a game of");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Guess the sound!");
            Console.ForegroundColor = ConsoleColor.White;

            SoundPlayer player = new SoundPlayer();
            string userGuess = "";

            Random random = new Random();
            int chosenAnimalIndex = random.Next(1, 6);

            // Determine the sound to play before the guessing starts
            string soundPath = "";
            string correctAnimal = "";

            switch (chosenAnimalIndex)
            {
                case 1:
                    soundPath = @"C:\Users\mkh09\VSCodeProjects\Taskset - Loops\AnimalSoundManager\sounds\cat.wav";
                    correctAnimal = "cat";
                    break;
                case 2:
                    soundPath = @"C:\Users\mkh09\VSCodeProjects\Taskset - Loops\AnimalSoundManager\sounds\cow.wav";
                    correctAnimal = "cow";
                    break;
                case 3:
                    soundPath = @"C:\Users\mkh09\VSCodeProjects\Taskset - Loops\AnimalSoundManager\sounds\goat.wav";
                    correctAnimal = "goat";
                    break;
                case 4:
                    soundPath = @"C:\Users\mkh09\VSCodeProjects\Taskset - Loops\AnimalSoundManager\sounds\goose.wav";
                    correctAnimal = "goose";
                    break;
                case 5:
                    soundPath = @"C:\Users\mkh09\VSCodeProjects\Taskset - Loops\AnimalSoundManager\sounds\rooster.wav";
                    correctAnimal = "rooster";
                    break;
            }

            // Play the sound before asking the user for input
            player.SoundLocation = soundPath;
            player.Play();
            Console.WriteLine("Listen carefully...");

            // Give a short delay so the user can hear the sound before guessing
            System.Threading.Thread.Sleep(3000);

            // Start the guessing loop
            do
            {
                Console.WriteLine("Which animal do you think makes this sound?");
                Console.WriteLine("Is it: Cat, Cow, Goat, Goose or Rooster?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Type:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" ´playsound´ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("to hear the sound again");
                Console.ForegroundColor = ConsoleColor.White;
                userGuess = Console.ReadLine().ToLower();

                if (userGuess == correctAnimal)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Correct! The animal was a {correctAnimal}!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (userGuess == "playsound")
                {
                    player.Play();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong! Try again!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (userGuess != correctAnimal);
        }
    }
}
