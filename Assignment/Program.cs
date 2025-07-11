// Program.cs
// EXCEEDS REQUIREMENTS:
// - Added CSV saving/loading functionality
// - Entries are saved in a format compatible with Excel
// - Properly escapes commas and quotes
// - Added 'Mood' field to encourage emotional reflection
// - Demonstrates abstraction via Journal and JournalEntry classes

using System;
using System.Collections.Generic;

class Program
{
    static List<string> prompts = new List<string>
    {
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who is the most interesting person you interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?"
    };

    static void Main()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string[] choices = { "Write", "Display", "Load", "Save", "Quit" };
        Journal journal = new Journal();
        int user = 0;

        while (user != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {choices[i]}");
            }

            Console.Write("What would you like to do? ");
            bool valid = int.TryParse(Console.ReadLine(), out user);

            if (!valid || user < 1 || user > 5)
            {
                Console.WriteLine("Invalid input. Please choose a number between 1 and 5.");
                continue;
            }

            if (user == 1)
            {
                string promptText = GetRandomPrompt();
                Console.WriteLine(promptText);
                string entryText = Console.ReadLine()!;
                Console.Write("How was your mood today? (e.g., Happy, Sad, Grateful): ");
                string mood = Console.ReadLine()!;

                journal.AddEntry(new JournalEntry
                {
                    Date = GetCurrentDate(),
                    PromptText = promptText,
                    EntryText = entryText,
                    Mood = mood
                });
            }
            else if (user == 2)
            {
                journal.DisplayEntries();
            }
            else if (user == 3)
            {
                Console.Write("What is the filename to load (.csv)? ");
                string fileName = Console.ReadLine()!;
                journal.LoadEntries(fileName);
            }
            else if (user == 4)
            {
                Console.Write("What is the filename to save (.csv)? ");
                string fileName = Console.ReadLine()!;
                journal.SaveEntries(fileName);
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }
    }

    static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    static string GetCurrentDate()
    {
        DateTime now = DateTime.Now;
        return $"{now.Month}/{now.Day}/{now.Year}";
    }
}