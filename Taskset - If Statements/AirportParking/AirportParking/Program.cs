namespace AirportParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Does the vechile have a parking license=");
            string licenseInput = Console.ReadLine();
            if (licenseInput == "yes")
            {
                Console.WriteLine("Okay, Is the license active?");
                string licenseActiveInput = Console.ReadLine();
                if (licenseActiveInput == "yes")
                {
                    Console.WriteLine("Okay, Is the time between 08.00 and 18.00?");
                    string hourInput = Console.ReadLine();
                    if (hourInput == "yes")
                    {
                        Console.WriteLine("This vehicle has a valid parking license and is parked withing acceptable timeframe. Parking Accepted");
                    }
                    else
                    {
                        Console.WriteLine("This vehicle is not parked legally. Please issue fine");
                    }
                }
                else
                {
                    Console.WriteLine("This vehicle is not parked legally. Please issue fine");
                }
            }
            else
            {
                Console.WriteLine("This vehicle is not parked legally. Please issue fine");
            }
            
        }
    }
}
