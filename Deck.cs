using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        string[] Suits = new string[] {"Diamond", "Club", "Heart", "Spade"};
        Dictionary<string, int> ValueDictionary = new Dictionary<string, int>
        {
            {"Ace", 1},{"2",2},{"3",3},{"4",4},{"5",5},{"6",6},{"7",7},{"8",8},{"9",9},{"10",10},{"J",10},{"Q",10},{"K",10}
        };
        List<Card> cards = new List<Card>();
        public Deck()
        {
            SetupDeck();
        }
        public void SetupDeck()
        {
            foreach (string suit in Suits)
            {
                foreach (KeyValuePair<string, int> cardValue in ValueDictionary)
                {
                    Card card = new Card(cardValue.Key, cardValue.Value, suit);
                    cards.Add(card);
                    Console.WriteLine(card.stringVal + " " + card.val + " " + card.suit);
                }
            }
        }
        public Card DealTopCard() 
        {
            Card card = cards[cards.Count-1];
            cards.RemoveAt(cards.Count-1);
            return card;

        }
        public void ShuffleDeck()
        {
            List<Card> shuffled = new List<Card>();
            for(int i=0;i<cards.Count;i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(cards.Count);
                shuffled.Add(cards[randomIndex]);
            }
            cards = shuffled;
        }
    }
}