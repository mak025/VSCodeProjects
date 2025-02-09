using System.Globalization;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {   //With aid from Rob

            //string dateString;
            //CultureInfo provider = CultureInfo.InvariantCulture;
            //provider = new CultureInfo("en-US");

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Task 7 Start");
            //Thread.Sleep(1000);
            //Console.ForegroundColor= ConsoleColor.White;
            //dateString = "15062008";
            //DateTime birthday = DateTime.ParseExact(dateString, "ddMMyyyy", provider);
            //Console.WriteLine($"{birthday}");
            //TimeSpan difference = DateTime.Now - birthday;
            //Console.WriteLine($"{difference}");


            //Below is an attempt to rewrite above code while writing notes in attempt to understand
            //various elements which Rob explained and implemented

            //This line creates a "provider" from which the format of DateTime is written into a string. This is necessary if the data held by
            //DateTime is to be written anywhere in a certain format. eg. US format MMddyyyy or MM-dd-yyyy or EN format dd-MM-yyyy
            CultureInfo provider = CultureInfo.InvariantCulture;
            provider = new CultureInfo("en-US");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 7 Start");
            Thread.Sleep(1000);
            Console.WriteLine("Enter the birthday of the person you are assisting. Format is: dd-MM-yyyy");
            Console.ForegroundColor= ConsoleColor.White;
            //This line grabs the current date and time from the system and stores that data in a string in the format dd-MM-yyyy
            string currentDate = DateTime.Now.ToString("dd-MM-yyyy");


            DateTime birthday = DateTime.ParseExact(currentDate, "dd-MM-yyyy", provider);
            TimeSpan difference = DateTime.Now - birthday;
            Console.WriteLine($"{difference}");
        }
    }
}
