using System;

namespace cse210
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their name
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine()!;
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine()!;
            Console.WriteLine();
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
   }
}