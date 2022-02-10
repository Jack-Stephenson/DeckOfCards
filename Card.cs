using System;
namespace DeckOfCards
{
    public class Card
    {
        public string stringVal;
        public int val;
        public string suit;
        public Card(string stringVal, int val, string suit)
        {
            this.stringVal = stringVal;
            this.val = val;
            this.suit = suit;
        }
    }
}