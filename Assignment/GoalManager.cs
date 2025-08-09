using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:\n1. Simple\n2. Eternal\n3. Checklist");
        string choice = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter target completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points! Total: {_score}");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
        Console.WriteLine($"Total Score: {_score}\n");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.SaveFormat());
            }
        }
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                var g = new SimpleGoal(name, desc, points);
                if (bool.Parse(parts[4])) g.RecordEvent();
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "ChecklistGoal")
            {
                var g = new ChecklistGoal(name, desc, points, int.Parse(parts[5]), int.Parse(parts[6]));
                for (int j = 0; j < int.Parse(parts[4]); j++) g.RecordEvent();
                _goals.Add(g);
            }
        }
    }
}
