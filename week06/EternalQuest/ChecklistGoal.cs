
using System.Runtime;

public class ChecklistGoal : Goal
{
    // Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }


    // Overriden methods
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Getters

    public override string GetDetailsString()
    {
        string checkBox = IsComplete() ? "[x]" : "[ ]";
        return $"{checkBox} {_shortName}: {_description} ({_amountCompleted}/{_target}) ({_points} points)";

    }
    
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_shortName}, {_description}, {_points}, {_amountCompleted}/{_target}, {_bonus}";
    }
}