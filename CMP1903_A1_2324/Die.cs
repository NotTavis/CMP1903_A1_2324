using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        //Makes a method to roll a dice
        public int RollDice()
        {//Method
        //Creates a random object called 'random'
        Random random = new Random();
        //gets a random number from 1 to 6 and assigns it to a variable 'diceroll
        int diceRoll = random.Next(1, 7);
        //returns the value held by diceroll
        return diceRoll;
        

        }
        

    }
}
