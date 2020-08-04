using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDeckClass
{
    /// <summary>
    /// Classes and Objects lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using a Deck class
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create and print a deck of cards
            Deck deck = new Deck();
            deck.Print();
        }
    }
}
