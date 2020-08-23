using System;
using System.Collections.Generic;
using ConsoleCards;

namespace Project9
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();
            deck.Shuffle();
            for(int i=0;i<5;i++)
            {
                hand.Add(deck.TakeTopCard());
            }
            foreach(Card card in hand)
            {
                card.FlipOver();
                card.Print();
            }
            Console.WriteLine();
        }
    }
}
