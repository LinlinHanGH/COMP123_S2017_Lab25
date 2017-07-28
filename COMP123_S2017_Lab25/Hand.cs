﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList class
 * Version: 0.5 - Added HighestCards() method
 */

namespace COMP123_S2017_Lab25
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes class variables and other objects
        /// </summary>
        protected override void _initialize()
        {
            // This is currently empty
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Hand contains:\n";
            outputString += "----------------------------------------------------\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        public void HighestCards()
        {
            Console.WriteLine("The most valuable card(s) in a hand is(are): ");
            Console.WriteLine("----------------------------------------------------");

            var highestCards = (from card in this orderby card.Face descending select card);

            foreach (var card in highestCards)
            {
                int temp = (int)highestCards.First().Face;
                if ((int)card.Face < temp)
                    break;
                else
                    Console.WriteLine(card);
            }
        }
    }
}