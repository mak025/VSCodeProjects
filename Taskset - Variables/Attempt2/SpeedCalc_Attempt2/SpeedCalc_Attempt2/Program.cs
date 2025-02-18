namespace SpeedCalc_Attempt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the distance the vehicle has travelled");
            double distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the time it took the vehicle to travel this distance");
            double timeMinutes = Convert.ToInt32(Console.ReadLine());
            double hour = (timeMinutes / 60);

            double avgSpeed = (distance / hour);

            Console.WriteLine("Calculating..");
            Thread.Sleep(1000);
            Console.WriteLine($"The Vehicle was travelling at {avgSpeed}");
        }
    }
}
