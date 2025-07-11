// Journal.cs

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine($"\n{entry.Date} - Prompt: {entry.PromptText}");
                Console.WriteLine($"Answer: {entry.EntryText}");
                Console.WriteLine($"Mood: {entry.Mood}");
            }
        }
    }

    public void SaveEntries(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,PromptText,EntryText,Mood");
                foreach (var entry in _entries)
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

    public void LoadEntries(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                var entry = JournalEntry.FromCsv(lines[i]);
                _entries.Add(entry);
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading file: " + ex.Message);
        }
    }
}
