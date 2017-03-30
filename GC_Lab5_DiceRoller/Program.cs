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
            int i = 1;
            bool run = true;
            while (run)
            {
                Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");
                run = Continue();
                while (run)
                {
                    Console.WriteLine("\nRoll " + i + ": ");
                    Console.WriteLine(roll.Next(1, 7));
                    Console.WriteLine(roll.Next(1, 7));
                    i++;
                    Console.Write("Roll again? (y/n):");
                    run = Continue();
                }
            }
            Console.ReadLine();
        }
        public static Boolean Continue()
        {            
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("\nGoodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}
