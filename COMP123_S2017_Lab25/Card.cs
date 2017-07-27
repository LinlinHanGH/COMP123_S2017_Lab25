using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Name: Linlin Han
 * Number: 300883493
 * Date: July 25, 2017
 * Description: This is the Card class to be used in the
 * card shuffling and dealing simulation
 * Version: 0.3 - Added ToString method
 */

namespace COMP123_S2017_Lab25
{
    public class Card : ICloneable
    {
        // PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;

        // PUBLIC PROPERTIES
        public Face Face
        {

            get
            {
                return this._face;
            }


            set
            {
                this._face = value;
            }


        }

        public Suit Suit
        {

            get
            {
                return this._suit;
            }

            set
            {
                this._suit = value;
            }


        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the Card class.
        /// It takes two parameters - face (Face) - suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }


        // PRIVATE METHODS

        // PUBLIC METHODS

        /// <summary>
        /// Returns a copy (clone) of the current card
        /// </summary>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

        public override string ToString()
        {
            string outputString = "";
            outputString += "The " + this.Face + " of " + this.Suit + "\n";
            return outputString;
        }

    }
}