using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        string Name;
        List<Card> Hand = new List<Card>();
        public Player(string name)
        {
            Name = name;
        }
        public Card DrawCard(Deck deck)
        {
            Card card = deck.DealTopCard();
            Hand.Add(card);
            return card;
        }
        public Card DiscardCard(int cardIndex)
        {
            if(cardIndex<Hand.Count)
            {
                Card card = Hand[cardIndex];
                Hand.RemoveAt(cardIndex);
                return card;
            }
            else
            {
                return null;
            }
        }
    }
}