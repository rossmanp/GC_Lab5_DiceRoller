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
            Random roll = new Random();
            int i = 1;
            bool run = true;
            int sides;
            Console.Write("Welcome to the Grand Circus Casino! Roll a pair of dice? (y/n):");
            run = Continue();      
                //If the user indicates "n", the entire loop is skipped and the program ends.        
                while (run)
                {
                    Console.Write("What is the number of sides on each die?");
                    int.TryParse(Console.ReadLine(), out sides);
                    while (run)
                    {
                        Console.WriteLine("\nRoll " + i + ": ");
                        int roll1 = Dice.roll.Next(1, sides + 1);
                        int roll2 = Dice.roll.Next(1, sides + 1);
                        Console.WriteLine(roll1);
                        Console.WriteLine(roll2);
                        //The result of the roll is then passed to CheckSpecialRoll
                        //in the Dice class to print a line if a 2, 7, or 12 is achieved.
                        Dice.CheckSpecialRoll(roll1, roll2);
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

