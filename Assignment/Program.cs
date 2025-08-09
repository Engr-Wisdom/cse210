using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save and Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                manager.CreateGoal();
            else if (choice == "2")
                manager.ListGoals();
            else if (choice == "3")
                manager.RecordEvent();
            else if (choice == "4")
            {
                manager.SaveGoals();
                break;
            }
        }
    }
}
