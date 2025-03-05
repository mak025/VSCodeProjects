namespace PlasticFantastic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard("1723 2374 1452 4252", "MasterCard", "$1264324", "Rob Latcham");
            CreditCard card2 = new CreditCard("8361 4127 3852 1234", "Express", "$3672420234432342342", "Jeff B.");
            CreditCard card3 = new CreditCard("4692 7852 9807 2345", "Visa");
            CreditCard card4 = new CreditCard("6724 6424 6478 5823", "TYPE");

            Console.WriteLine(card);
            Console.WriteLine("");
            Console.WriteLine(card2);
            Console.WriteLine("");
            Console.WriteLine(card3);
            Console.WriteLine(card4);
        }
    }
}
