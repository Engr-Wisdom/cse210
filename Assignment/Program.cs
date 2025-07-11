using System;
using System.Collections.Generic;

class JournalEntry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }
}

class Program
{
    static List<string> prompts = new List<string>
    {
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who is the most interesting person you interacted with today?"
    };

    static List<JournalEntry> diaryEntries = new List<JournalEntry>();

    static void Main()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string[] choices = { "Write", "Display", "Load", "Save", "Quit" };

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

                diaryEntries.Add(new JournalEntry
                {
                    Date = GetCurrentDate(),
                    PromptText = promptText,
                    EntryText = entryText
                });
            }
            else if (user == 2)
            {
                if (diaryEntries.Count == 0)
                {
                    Console.WriteLine("No journal entries to display.");
                }
                else
                {
                    foreach (var entry in diaryEntries)
                    {
                        Console.WriteLine($"\n{entry.Date} - Prompt: {entry.PromptText}");
                        Console.WriteLine($"Answer: {entry.EntryText}");
                    }
                }
            }
            else if (user == 3)
            {
                Console.Write("What is the filename to load? ");
                string fileName = Console.ReadLine()!;
                Console.WriteLine($"Load: {fileName}");
            }
            else if (user == 4)
            {
                Console.Write("What is the filename to save? ");
                string fileName = Console.ReadLine()!;
                Console.WriteLine($"Saved {fileName}");
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
        return $"Date: {now.Month}/{now.Day}/{now.Year}";
    }
}
