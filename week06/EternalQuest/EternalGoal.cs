
public class EternalGoal : Goal
{

    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // Overriden methods
    public override void RecordEvent()
    {
        // No completion for eternal goals, just add points
    }
    public override bool IsComplete()
    {
        return false;
    }

    // Getter
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}";
    }
}