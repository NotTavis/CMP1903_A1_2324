using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            //creates a single die and rolls it
            Die die = new Die();
            int dieSide = die.RollDice();
            //outputs what is happening in this stage
            Console.WriteLine("Stage 1, a single die is rolled and gives a value from 1 to 6");
            //outputs the result of this stage
            Console.WriteLine("The die rolled a " + dieSide);
            //uses the game class to create a new game
            Game game = new Game();
            //the game class returns the sum of rolls value
            int sumOfRolls = game.CreateGame();
            //explains the game class 
            Console.WriteLine("Stage 2, three die are rolled, their values are summed up");
            //outputs the result of the game
            Console.WriteLine("The total of the three dices was " + sumOfRolls);
            //tests to make sure the values from the single die and the gam are within the corect range
            Testing.Tests();





            Console.ReadLine();

        }
    }
}
