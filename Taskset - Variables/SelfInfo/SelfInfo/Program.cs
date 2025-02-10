namespace SelfInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 2 Start "Write a program to print your Fullname, Address"

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Task 2 Start");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello Magnus Malthe Kim-Hansen");
            Console.WriteLine("You live at Heliosvej 1 4200 Slagelse/Drøsselbjerg");
            Console.Write("Today is ");
            Console.WriteLine(DateTime.Now.ToString("dd-MM-yy"));

            //Second version of Task 2
            //Print using $ operator <- string operator
            string name = "Magnus Hansen";
            int age = 26;
            Console.WriteLine($"{name} er {age} år gammel");
            //output: Magnus Hansen er 26 år gammel
            //Task 2 End
        }
    }
}
