namespace SortingHat
{
    
    internal class Program
    {
        public enum HogwartsHouse //Her oprettes en Enum som indeholder Hogwarts Husene
        {
            Gryffindor, Hufflepuff, Ravenclaw, Slytherin
        };


        private static Random rnd = new Random(); // Her oprettes en random funktion som bruges nedenunder til at vælge et tilfældigt hus fra HogwartsHouse enum


        public static HogwartsHouse RandomHouse() //Her oprettes metoden som vi kalder senere
        {
            //Her loades alle værdier fra HogwartsHouse (enum) ind i et array
            HogwartsHouse[] random = (HogwartsHouse[])Enum.GetValues(typeof(HogwartsHouse));

            return random[rnd.Next(random.Length)];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the SortingHat! Here you will be assigned a Hogwarts House");
            Console.WriteLine("Pess ENTER to get a house assigned for the remainder of your studies in magic and witchcraft...");
            Console.ReadLine();

            Console.WriteLine($"You've been assigned the: {RandomHouse()} house!");
        }

    }
}
