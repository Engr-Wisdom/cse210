using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override bool IsComplete() => false;

    public override int RecordEvent()
    {
        return Points; // Always adds points
    }

    public override string GetStatus()
    {
        return $"[∞] {Name} ({Description})";
    }
}
