
using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _duration; // in minutes (remider)

    // Constructor
    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Getters
    public DateTime GetDate()
    {
       return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }

    // abstract methods
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // virtual method
    // Note: this.GetType() gets the runtime type of the object
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}

