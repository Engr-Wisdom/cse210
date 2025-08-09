using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override bool IsComplete() => _timesCompleted >= _target;

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (IsComplete())
        {
            return Points + _bonus;
        }
        return Points;
    }

    public override string GetStatus()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {Name} ({Description}) -- Completed {_timesCompleted}/{_target}";
    }

    public override string SaveFormat()
    {
        return base.SaveFormat() + $"|{_timesCompleted}|{_target}|{_bonus}";
    }
}
