using System;

namespace cse210
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which exercise would you like to run?");
            Console.WriteLine("1 - Exercise1");
            Console.WriteLine("2 - Exercise2");
            Console.WriteLine("3 - Exercise3");
            Console.WriteLine("4 - Exercise4");
            Console.WriteLine("5 - Exercise5");
            Console.Write("Enter a number (1–5): ");
            string input = Console.ReadLine()!;

            Console.WriteLine(); // optional spacing

            switch (input)
            {
                case "1":
                    Exercise1.Run();
                    break;
                case "2":
                    Exercise2.Run();
                    break;
                case "3":
                    Exercise3.Run();
                    break;
                case "4":
                    Exercise4.Run();
                    break;
                case "5":
                    Exercise5.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
