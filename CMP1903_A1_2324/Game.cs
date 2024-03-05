using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        //makes a method that will execute the game
        public int CreateGame()
        {//Methods
        //creates a new die object and rolls it
        Die die1 = new Die();
        int dieSide1 = die1.RollDice();
        //creates a second die object and rolls it
        Die die2 = new Die();
        int dieSide2 = die2.RollDice();
        //creates a final die object and rolls it
        Die die3 = new Die();
        int dieSide3 = die3.RollDice();
        //adds the results of the three dice rolls together and assigns that value to the variable sumOfRolls
        int sumOfRolls = dieSide1 + dieSide2 + dieSide3;
        //returns the value in sum of rolls
        return sumOfRolls;

        
        }
            


    }
}
