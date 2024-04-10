using System;
using System.Collections.Generic;

class Running : Activity
{
    private double _distance { get; set; }

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_duration / 60.0);
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance:F2} kms, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
}
