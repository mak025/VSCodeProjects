namespace SpeedCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 5 Start
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Task 5 Start");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Indtast antal km");
            double distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast tiden det tod at tilbagelægge strækningen");
            double tidMinutes = Convert.ToInt32(Console.ReadLine());

            double timer = (tidMinutes / 60);
            double avgSpeed = (distance / timer);
            Console.WriteLine($"Bilisten kørte {avgSpeed} km/t");
        }
    }
}
