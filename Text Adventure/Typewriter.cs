using System;
using System.Threading;

namespace Text_Adventure
{
    class Typewriter
    {
        public static void Write(string text)
        {
            Random rnd = new Random();
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(rnd.Next(15, 30));
            }
        }

        // Don't use, currently fucked
        public static void WriteLine(string text)
        {
            Random rnd = new Random();
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(rnd.Next(30, 60));
                Console.WriteLine();
            }
        }
    }
}
