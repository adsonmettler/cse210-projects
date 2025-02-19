

public class Swimming : Activity
{
    private int _laps;
    private const double LapLength = 50.0 / 1000; // 50 meters per lap converted to km (constant)

    // Constructor
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    // Overriden methods
    public override double GetDistance()
    {
        return _laps * LapLength;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}