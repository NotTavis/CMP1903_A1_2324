using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */
        public static void Tests()
        {
            //creates two methods to test the die and the game within one called tests
            TestDie();
            TestTotal();

        }
        public static void TestDie()
        {
            //rolls a die 
            Die die = new Die();
            int dieSide = die.RollDice();
            //checks that the die rolled has a value that is not less than 1 and not greater than 6 
            Debug.Assert(dieSide >= 1 & dieSide <= 6, "The Dice rolled a value which fell out of the correct range.");
        }

        public static void TestTotal()
        {
            //creates the game using 3 dice
            Game game = new Game();
            int sumOfRolls = game.CreateGame();
            //checks that the value of the 3 dice added together is not less than 3 as the lowest it could be is 3 from 3 dice rolling 1
            //and checks that it is not greater than 18 as 3 dice rolling 6 would make 18
            Debug.Assert(sumOfRolls >= 3 & sumOfRolls <= 18, "The total of the three dice fell out of the correct range.");
        }
    }
}
