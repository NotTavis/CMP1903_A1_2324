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
        public int CreateGame()
        {//Methods
        Die die_1 = new Die();
        int dieside_1 = die_1.RollDice();

        Die die_2 = new Die();
        int dieside_2 = die_2.RollDice();

        Die die_3 = new Die();
        int dieside_3 = die_3.RollDice();

        int SumOfRolls = dieside_1 + dieside_2 + dieside_3;
        return SumOfRolls;

        
        }
            


    }
}
