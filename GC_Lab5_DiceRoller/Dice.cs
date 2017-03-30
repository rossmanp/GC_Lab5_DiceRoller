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
