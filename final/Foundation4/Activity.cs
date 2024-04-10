using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime _date { get; set; }
    protected int _duration { get; set; }

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} - {GetType().Name} ({_duration} min)";
    }
}