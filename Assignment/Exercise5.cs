using System;

namespace cse210
{
    public class Exercise5
    {
        public static void Run()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int squareNumber = SquareNumber(favoriteNumber);
            DisplayResult(name, squareNumber);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine()!;
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNum = int.Parse(Console.ReadLine()!);
            return favoriteNum;
        }

        static int SquareNumber(int number)
        {
            int num = (int)Math.Pow(number, 2);
            return num;
        }

        static void DisplayResult(string name, int squareNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        }
    }
}
