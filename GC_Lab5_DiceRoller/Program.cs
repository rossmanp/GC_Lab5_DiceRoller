using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab5_DiceRoller
{
    class Program
    {
        //This program prompts the user if he or she wants to roll a pair of dice, and 
        //if so, the number of sides on each die. The program then rolls the dice and
        //prompts the user if he or she wants to roll again.

        static void Main(string[] args)
        {
            int i = 1;
            bool run = true;
            int sides;
            Console.Write("Welcome to the Grand Circus Casino! Roll a pair of dice? (y/n):");
            run = Continue();      
                //If the user indicates "n", the entire loop is skipped and the program ends.        
            while (run)
            {
                    Console.Write("What is the number of sides on each die: ");
                    sides = IntValidator.getIntWithinRange(3, Int32.MaxValue);
                    while (run)
                    {
                        Console.WriteLine("\nRoll " + i + ": ");
                        Dice.RollDice(sides);
                        i++;
                        Console.Write("\nRoll again? (y/n):");
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

