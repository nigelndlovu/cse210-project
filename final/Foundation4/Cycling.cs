using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double _speed { get; set; }

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed:F2} kph, Pace: {GetPace():F2} min/km";
    }
}