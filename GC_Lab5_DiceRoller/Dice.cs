using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab5_DiceRoller
{
    class Dice
    {
        public static Random roll = new Random();

        public Dice()
        {

        }

        //Displays special messages if a user rolls a 2, 7, or 12.

        public static int Roll(int min, int max) => Dice.roll.Next(min, max + 1);

        public static void RollDice(int sides)
        {
            int roll1 = Dice.Roll(1, sides);
            int roll2 = Dice.Roll(1, sides);
            Console.WriteLine(roll1 + "\n" + roll2);
            Dice.CheckSpecialRoll(roll1, roll2);
        }

        public static void CheckSpecialRoll(int roll1, int roll2)
        {
            if (roll1 + roll2 == 2)
            {
                Console.WriteLine("Snake eyes!");
            }
            if (roll1 + roll2 == 7)
            {
                Console.WriteLine("Craps!");
            }
            if (roll1 + roll2 == 12)
            {
                Console.WriteLine("Boxcars!");
            }
        }
    }
}
