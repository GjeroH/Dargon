using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_DO_NOT_KNOW
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declar variable for player answers
            string playerAnswer = "nil";

            // Start of adventure
            Console.WriteLine("While walking through a dark and forboding forest, you come across a cave entrance. " +
                                "\n\nIt's starting to rain and it's nearly night.\n\nDo you enter?");

            // Ask for player answer and store in variable
            playerAnswer = Console.ReadLine();

            // What happens to player based on answer
            if (playerAnswer == "yes")
            {
                Console.WriteLine("You have survived.");
            }
            else
            {
                Console.WriteLine("You have died of hypothermia in the rain.");
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }

            // Ask player what they want to do now
            Console.WriteLine("Would you like to play again?");
            Console.ReadKey();
        }
    }
}