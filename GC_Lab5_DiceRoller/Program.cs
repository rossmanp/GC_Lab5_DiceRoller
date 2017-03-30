using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab5_DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random roll = new Random();
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
            Console.WriteLine("\nRoll 1:");
            Console.WriteLine(roll.Next(1, 7));
            Console.WriteLine(roll.Next(1, 7));
            Console.WriteLine("Roll again?");
            Console.ReadLine();      
        }
    }
}
