namespace LightSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lights on = true || Lights off = false
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("POWER OUTAGE! Turn on the lights on the breakerbox!");
            string input = "";
            input = Console.ReadLine();
            bool lights = false;

            //create do-while loop with if and else if statements (three statements in total) where each either turns on, turns off or exits the loop
            do
            {
                if (input == "breakerON")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Let there be light!... Hopefully the power doesnt go.. (type: breakerOFF)");
                    input = Console.ReadLine();
                }
                if (input == "breakerOFF")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("POWER OUTAGE! Turn on the lights on the breakerbox!");
                    input = Console.ReadLine();
                }
                if (input == "exit")
                {
                    lights = true;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                else
                {
                    Console.WriteLine("ERROR! CODE 40! Command Unknown");
                    input = Console.ReadLine();
                }
            }

            while (lights == false); //condition here
            
        }
    }
}
