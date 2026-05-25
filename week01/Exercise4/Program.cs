
using System;
using System.Security.Principal;

namespace Function
{
 class Program
{
    static void Main(string[] arg)
        {
            void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the Program!");
            }

            string PromptUserName()
            {
                Console.Write("Please enter your name: ");
                string userName = Console.ReadLine();
                return userName;
            }

            int PromptUserNumber()
            {
                Console.Write("Please enter your favorite number: ");
                int favoriteNum = int.Parse(Console.ReadLine());
                return favoriteNum;
            }

            int SquareNumber(int number)
            {
                int square = number * number;
                return square;
            }

            DisplayWelcome();
            string userName = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int square = SquareNumber(favoriteNumber);

            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
    }   
}