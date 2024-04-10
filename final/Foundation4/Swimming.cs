using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _laps { get; set; }

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_duration / 60.0); 
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
}
