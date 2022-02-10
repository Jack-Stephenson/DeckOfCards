using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.ShuffleDeck();
            Player Jack = new Player("Jack");
            Jack.DrawCard(deck);
            Jack.DrawCard(deck);
            Jack.DiscardCard(1);
            Jack.DiscardCard(11);
        }
    }
}
