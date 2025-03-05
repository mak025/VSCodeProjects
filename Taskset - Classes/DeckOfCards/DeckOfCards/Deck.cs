using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    //                                                              Enums are used below to prevent the use of invalid values. Eg when {get;} is used later
    //                                                              the program knows that only specific values (constants) are valid
    public enum CardValue
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, //"Two = 2" is used here to tell the enum array that the value of the first index
        Jack, Queen, King, Ace //                                    entry is 2 rather than 0 as in a deck of cards the lowest value is usually 2
    }

    public enum Suits
    {
        Hearts, Diamonds, Clubs, Spades
    }

    public class Card
    {
        public CardValue Value { get; }
        public Suits Suit { get; }

        public Card(CardValue value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
