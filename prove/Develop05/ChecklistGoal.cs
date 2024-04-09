using System;
using System.Collections.Generic;
using System.IO;

public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    private bool _isComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _amountCompleted = _target;
            //_score += _points + _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} ({_amountCompleted}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"{nameof(ChecklistGoal)},{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}