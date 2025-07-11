// JournalEntry.cs

using System;
using System.Collections.Generic;
using System.Text;

public class JournalEntry
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

    private static string[] SplitCsv(string input)
    {
        List<string> fields = new List<string>();
        bool inQuotes = false;
        StringBuilder field = new StringBuilder();

        foreach (char c in input)
        {
            if (c == '"')
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
