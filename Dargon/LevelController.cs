using System;
using System.Collections.Generic;
using System.Text;

namespace Dargon
{
    class LevelController
    {
        public static void NewLevel()
        {
            Typewriter.Write($"While walking through a dark forest the brave adventurer {Program.playerName} came across a cave entrance.\n\nIt started to rain and was nearly night.\n\nDid {Program.playerName} enter? ");

            // Ask for player answer and store in variable
            Program.playerAnswer = Console.ReadLine();

            // What happens to player based on answer
            if (Program.playerAnswer == "yes")
            {
                Typewriter.Write($"{Program.playerName} has survived.");
            }
            else
            {
                Typewriter.Write($"{Program.playerName} has died of hypothermia in the rain.");
            }
            Program.GameOverChoice();
        }
    }
}
