

public class Cycling : Activity
{
    private double _speed; // in kph

    // Constructor
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    // Overriden methods
    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}