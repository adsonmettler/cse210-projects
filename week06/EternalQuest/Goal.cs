
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        string checkBox = IsComplete() ? "[x]" : "[ ]";
        return $"{checkBox} {_shortName}: {_description} ({_points} points)";
    }
    
    public abstract string GetStringRepresentation();
    public int GetPoints()
    {
        return _points;
    }
}