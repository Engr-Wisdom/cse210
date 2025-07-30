// I added more scriptures. When the user run the program it randomly choose to a scripture
// I also added a text to display when thhe user type quit

using System;
using System.Collections.Generic;

class Program
{
    static void RunScriptureMemorizer()
    {
 
        var scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
            
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            
            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."),
            
            new Scripture(new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."),
            
            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me.")
        };

        Random rand = new Random();
        int index = rand.Next(scriptureLibrary.Count);
        var scripture = scriptureLibrary[index];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayCurrentScripture());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program complete!");
                break;
            }

            Console.Write("\nPress Enter to hide more words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                scripture.HideRandomWords();
            }
            else if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Program ended by user.");
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        RunScriptureMemorizer();
    }
}
