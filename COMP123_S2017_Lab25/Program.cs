using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 25, 2017
 * Description: Demo for Lesson 11
 * Version: 0.5 - Updated the Program class to call Deal5() method and Highest method
 */

namespace COMP123_S2017_Lab25
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); // new empty Hand container

            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();

            hand = deck.Deal5(); // creates a new Hand object and assigns it to hand
            Console.WriteLine(hand.ToString());
            hand.HighestCards();
        }
    }
}
