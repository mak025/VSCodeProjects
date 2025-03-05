namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] deck1 = new Card[52];
            Suits[] suits = (Suits[])Enum.GetValues(typeof(Suits));
            int counter = 0;

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 2; j <= 14; j++) // Adjust the loop to match the CardValue enum
                {
                    CardValue value = (CardValue)j; // Convert j to CardValue
                    deck1[counter] = new Card(value, suits[i]);
                    counter++;
                }
            }
        }
    }
}
