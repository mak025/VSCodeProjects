namespace Seasons
{
    internal class Program
    {
             
        public enum Seasons { Spring, Summer, Fall, Winter, Invalid}
        public static Seasons FindSeason(string month)
        {
            if (month == "December")
            {
                return Seasons.Winter;
            }
            else if (month == "January")
            {
                return Seasons.Winter;
            }
            else if (month == "Febuary")
            {
                return Seasons.Winter;
            }
            else if (month == "March")
            {
                return Seasons.Spring;
            }
            else if (month == "April")
            {
                return Seasons.Spring;
            }
            else if (month == "May")
            {
                return Seasons.Spring;
            }
            else if (month == "June")
            {
                return Seasons.Summer;
            }
            else if (month == "July")
            {
                return Seasons.Summer;
            }
            else if (month == "August")
            {
                return Seasons.Summer;
            }
            else if (month == "September")
            {
                return Seasons.Fall;
            }
            else if (month == "October")
            {
                return Seasons.Fall;
            }
            else if (month == "November")
            {
                return Seasons.Fall;
            }
            else
            {
                return Seasons.Invalid;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of a month - Remember to capitalize the first letter");
            string inputMonth = Console.ReadLine();
            Console.WriteLine($"{inputMonth} is part of the {FindSeason(inputMonth)} season");
        }
    }
}
