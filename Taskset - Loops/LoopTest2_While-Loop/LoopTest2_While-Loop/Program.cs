namespace LoopTest2_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool schoolIsFun = true;
            while (schoolIsFun)
            {
                Console.WriteLine("School is fun");
                if (DateTime.Now().DayOfWeek == DayOfWeek.Friday)
                { schoolIsFun = false; }

            }
            Console.WriteLine("Hello, World!");
        }
    }
}
