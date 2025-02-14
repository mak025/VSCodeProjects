namespace LightSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POWER OUTAGE! Turn on the lights on the breakerbox!");
            Console.WriteLine("Turn on the breaker by typing: breakerON");

            //Lights on = true || Lights off = false
            string input = "";
            //create do-while loop with if and else if statements (three statements in total) where each either turns on, turns off or exits the loop
            do
            {
                if()
            }
            bool lights = false;
            Console.BackgroundColor = ConsoleColor.Black;

            while (lights == false)
            {

                string input = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                if(input == "breakerON")
                {
                    lights = true;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("POWER IS ON");
                    Thread.Sleep(500);
                    Console.WriteLine("Turn off the power with: breakerOFF");

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Lights are off");
                }

            }
            
        }
    }
}
