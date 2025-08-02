using System;
using System.Threading;

namespace MindfulnessProgram.Utils
{
    public static class AnimationHelper
    {
        public static void ShowSpinner(int seconds)
        {
            string[] symbols = { "|", "/", "-", "\\" };
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(symbols[i % symbols.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
                i++;
            }
        }

        public static void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            Console.WriteLine();
        }
    }
}
