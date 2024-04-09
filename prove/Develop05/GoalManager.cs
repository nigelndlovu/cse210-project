using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {(goal.IsComplete() ? "[X]" : "[ ]")} - {goal.GetDetailsString()}");
            Console.WriteLine();
        }
    }

    public void CreateGoal(string shortName, string description, string points, int target = 0, int bonus = 0)
    {
        Goal newGoal;
        if (target > 0)
        {
            newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
        }
        else if (target == 0 && bonus == 0)
        {
            newGoal = new EternalGoal(shortName, description, points);
        }
        else
        {
            newGoal = new SimpleGoal(shortName, description, points);
        }
        _goals.Add(newGoal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goalIndex;
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        _score = 0;
        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string typeName = parts[0];
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];

                Goal goal;
                switch (typeName)
                {
                    case nameof(SimpleGoal):
                        goal = new SimpleGoal(shortName, description, points);
                        break;
                    case nameof(EternalGoal):
                        goal = new EternalGoal(shortName, description, points);
                        break;
                    case nameof(ChecklistGoal):
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        goal = new ChecklistGoal(shortName, description, points, target, bonus)
                        {
                            _amountCompleted = amountCompleted
                        }; 
                        break;
                    default:
                        throw new InvalidOperationException("Invalid goal type found in file.");
                }
                _goals.Add(goal);
            }
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
}