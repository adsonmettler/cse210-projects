
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Overriden methods
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Getter
    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
}