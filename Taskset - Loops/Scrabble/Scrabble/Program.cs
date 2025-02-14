using System.ComponentModel;
using System.Diagnostics.Tracing;

namespace Scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User enters a word in lower caps
            Console.WriteLine("Enter a word in lower caps! eg. monkey");
            string inputWord = Console.ReadLine();

            //tracking the score of inputWord
            int pointTotal = 0;
            
            


            //App looks at the letters in the word entered and calculates the sum of the values for each letter
            for (int i = 0; i < inputWord.Length -1; i++)
            {
                char letter = inputWord[i];
                if (letter == 'a' || letter == 'e' || letter == 'n' || letter == 'r')
                {
                    pointTotal = pointTotal + 1;
                }

                if (letter == 'd' || letter == 'l' || letter == 'o' || letter == 's' || letter == 't')
                {
                    pointTotal = pointTotal + 2;
                }

                if (letter == 'b' || letter == 'i' || letter == 'k' || letter == 'f' || letter == 'g' || letter == 'm' || letter == 'u' || letter == 'v')
                {
                    pointTotal = pointTotal + 3;
                }

                if (letter == 'h' || letter == 'j' || letter == 'p' || letter == 'y' || letter == 'æ' || letter == 'ø' || letter == 'å')
                {
                    pointTotal = pointTotal + 4;
                }

                if (letter == 'c' || letter == 'x' || letter == 'z' || letter == 'w' || letter == 'q')
                {
                    pointTotal = pointTotal + 8;
                }
                Console.Clear();
                Console.WriteLine($"Your word score is: {pointTotal}");

            }

        }
    }
}
