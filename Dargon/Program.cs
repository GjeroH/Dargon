using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dargon
{
    class Program
    {
        public static string playerName;
        public static string playerAnswer;

        static void Main()
        {
            StartAdventure();
        }

        static void StartAdventure()
        {
            Console.Write("Welcome to my text adventure.\n--------------------------------------------------\nWhat is your name? ");
            playerName = Console.ReadLine();
            LevelController.NewLevel();
        }

        public static void GameOverChoice()
        {
            Console.Beep();
            Console.Beep();
            Console.Beep();

            Console.WriteLine();
            Console.Write("--------------------------------------------------\nWould you like to play again? ");

            playerAnswer = Console.ReadLine();
            if (playerAnswer == "yes")
            {
                StartAdventure();
            }
            else
            {
                return;
            }
        }
    }
}