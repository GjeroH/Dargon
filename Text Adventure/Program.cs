using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I_DO_NOT_KNOW
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variable for player name and answers
            string playerName;
            string playerAnswer = "nil";

            // Start of adventure
            Console.Write("Welcome to my text adventure.\n--------------------------------------------------\nWhat is your name? ");
            playerName = Console.ReadLine();


            SlowWriter.Write("While walking through a dark forest the brave adventurer " + playerName +
                              " came across a cave entrance. " +
                              "\n\nIt started to rain and was nearly night.\n\nDid " + playerName + " enter?");

            // Ask for player answer and store in variable
            playerAnswer = Console.ReadLine();

            // What happens to player based on answer
            if (playerAnswer == "yes")
            {
                SlowWriter.Write(playerName + " has survived.");
            }
            else
            {
                SlowWriter.Write(playerName + " has died of hypothermia in the rain.");
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }

            // Ask player what they want to do now
            Console.Write("--------------------------------------------------\nWould you like to play again? ");
            Console.ReadKey();
        }
    }

    public class SlowWriter
    {

        public static void Write(string text)
        {
            Random rnd = new Random();
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(rnd.Next(30, 60));
            }
        }
    }
}