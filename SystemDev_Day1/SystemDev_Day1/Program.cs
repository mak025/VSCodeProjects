using System.Runtime.CompilerServices;

namespace SystemDev_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If a string holding a number is used in a math expression with an int variable holding a number,
            //then the numbers wont be subtracted / added etc but just written next to one another
            //If both are the same type eg both are int, then the math will math

            //General informational questionaire. Is a phonenumber a string or an in function?
            //Phone numbers dont need to be calulated / used in a math expression. therefore they are a string
            Console.WriteLine("Below is an example where a string is added to an int");
            int intnumber = 3;
            string stringnumber = "3";
            Console.WriteLine(stringnumber + intnumber);
            Thread.Sleep(1000);
            Console.WriteLine("As you can see the numbers are written next to eachother");
            Thread.Sleep(500);
            Console.WriteLine("If both variables were int variables. Then the numbers would be *mathed");
            Thread.Sleep(500);
            Console.WriteLine("Below is an example where both variables are int");
            int intnumber1 = 3;
            int intnumber2 = 3;
            Console.WriteLine(intnumber1 + intnumber2);
        }
    }
}
