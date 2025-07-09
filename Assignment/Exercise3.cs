using System;

namespace cse210
{
    public class Exercise3
    {
        public static void Run()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guess = -1;
            int guess_count = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine()!);
                guess_count++;

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it! \nIt took you {guess_count} guesses");
                }
            }
        }
    }
}
