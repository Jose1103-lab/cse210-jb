using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _shortName = name;
        _description = description;
        _points = point;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine($"You have already completed the goal: {_shortName}");
        }
        else
        {
            _amountCompleted++;

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have completed the goal: {_shortName}");
                Console.WriteLine($"You have earned {_bonus} points!");
            }
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return $"{_shortName},({_description}), status: {_amountCompleted}/{_target}"; ;
    }

    public override string GetStringRepresentation()
    {
        if (IsComplete())
        {
            return $"[✓] {_shortName}, {_description}";
        }
        else
        {
            return $"[ ] {_shortName}, {_description}";
        }
    }



}