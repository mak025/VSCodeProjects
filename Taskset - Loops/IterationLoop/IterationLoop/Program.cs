namespace IterationLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 8;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Iteration {i}: x= {x}, y = {y}");
                if (x * 2 > y)
                {
                    Console.WriteLine("x gange 2 er større end y");
                }
                else if (x + y < 15)
                {
                    Console.WriteLine("Summen af x og y er mindre end 15");
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("x er et lige tal.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingen betingelse opfyldt");
                }
                x += 3;
                y -= 2;

            }

            Console.WriteLine($"y: {y}");
        }
    }
}
