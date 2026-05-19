// using System;
// using GeneratePrompt;
// using JournalEntry;
// using JournalManager;
// class Program
// {
//     static void Main(string[] arg)
//     {
//         Journal myJournal = new Journal();

//         bool running = true;

//         while (running)
//         {
//             Console.WriteLine("\nPlease select one of the following choices:");
//             Console.WriteLine("1. Write");
//             Console.WriteLine("2. Display");
//             Console.WriteLine("3. Load");
//             Console.WriteLine("4. Save");
//             Console.WriteLine("5. Quit");

//             Console.Write("What would you like to do? ");
//             int choice = int.Parse($"{Console.ReadLine()}");
//             Console.WriteLine();

//             if (choice == 1)
//             {
//                 Entry newEntry = new Entry();
//                 PromptGenerator newPrompt = new PromptGenerator();
//                 newEntry._prompt = newPrompt.RandomPrompt();
//                 Console.Write(newEntry._prompt);
//                 string response = Console.ReadLine();
//                 newEntry._response = response;

//                 myJournal._entries.Add(newEntry);

//             }

//             else if (choice == 2)
//             {
//                 myJournal.DisplayJournal();
//             } 

//             else if (choice == 3)
//             {
//                 Console.Write("What is the filename? ");
//                 string fileName = Console.ReadLine();
//                 myJournal.LoadFromFile(fileName);

//             } 

//             else if (choice == 4)
//             {
//                 Console.Write("What is the filename? ");
//                 string fileName = Console.ReadLine();
//                 myJournal.SaveToFile(fileName);

//             } 
            
//             else if (choice == 5)
//             {
//                 running = false;
//             } 
            
//             else
//             {
//                 Console.WriteLine("Invalid option");
//             }
//         }
//     }
// }