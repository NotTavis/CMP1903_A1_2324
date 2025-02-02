﻿using System;
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
            TestDie();
            TestTotal();

        }
        public static void TestDie()
        {
            Die die = new Die();
            int dieside = die.RollDice();

            Debug.Assert(dieside >= 1 & dieside <= 6, "The Dice rolled a value which fell out of the correct range.");
        }

        public static void TestTotal()
        {
            Game game = new Game();
            int SumOfRolls = game.CreateGame();

            Debug.Assert(SumOfRolls >= 3 & SumOfRolls <= 18, "The total of the three dice fell out of the correct range.");
        }
    }
}
