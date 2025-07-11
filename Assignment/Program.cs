// I added the following code to my program 

// - Added CSV saving/loading functionality
// - Entries are saved in a format compatible with Excel
// - Properly escapes commas and quotes
// - Added 'Mood' field to encourage emotional reflection
// - Demonstrates abstraction via JournalEntry class and helper methods

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class JournalEntry
{
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }
    public string Mood { get; set; }

    public string ToCsv()
    {
        return $"\"{Date}\",\"{PromptText.Replace("\"", "\"\"")}\",\"{EntryText.Replace("\"", "\"\"")}\",\"{Mood}\"";
    }

    public static JournalEntry FromCsv(string line)
    {
        string[] parts = SplitCsv(line);
        return new JournalEntry
        {
            Date = parts[0].Trim('"'),
            PromptText = parts[1].Trim('"'),
            EntryText = parts[2].Trim('"'),
            Mood = parts[3].Trim('"')
        };
    }

    // Helper to parse CSV with quoted fields
    private static string[] SplitCsv(string input)
    {
        List<string> fields = new List<string>();
        bool inQuotes = false;
        StringBuilder field = new StringBuilder();

        foreach (char c in input)
        {
            if (c == '\"')
            {
                inQuotes = !inQuotes;
                continue;
            }

            if (c == ',' && !inQuotes)
            {
                fields.Add(field.ToString());
                field.Clear();
            }
            else
            {
                field.Append(c);
            }
        }
        fields.Add(field.ToString());
        return fields.ToArray();
    }
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
                Console.Write("How was your mood today? (e.g., Happy, Sad, Grateful): ");
                string mood = Console.ReadLine()!;

                diaryEntries.Add(new JournalEntry
                {
                    Date = GetCurrentDate(),
                    PromptText = promptText,
                    EntryText = entryText,
                    Mood = mood
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
                        Console.WriteLine($"Mood: {entry.Mood}");
                    }
                }
            }
            else if (user == 3)
            {
                Console.Write("What is the filename to load (.csv)? ");
                string fileName = Console.ReadLine()!;
                LoadEntries(fileName);
            }
            else if (user == 4)
            {
                Console.Write("What is the filename to save (.csv)? ");
                string fileName = Console.ReadLine()!;
                SaveEntries(fileName);
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

    static void SaveEntries(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,PromptText,EntryText,Mood");
                foreach (var entry in diaryEntries)
                {
                    writer.WriteLine(entry.ToCsv());
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving file: " + ex.Message);
        }
    }

    static void LoadEntries(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            diaryEntries.Clear();

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                var entry = JournalEntry.FromCsv(lines[i]);
                diaryEntries.Add(entry);
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading file: " + ex.Message);
        }
    }
}
