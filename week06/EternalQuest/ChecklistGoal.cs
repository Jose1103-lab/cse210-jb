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
            Console.WriteLine($"You have completed {_amountCompleted} out of {_target} for the goal: {_shortName}");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have completed the goal: {_shortName}");
                _points += _bonus;
                Console.WriteLine($"You have earned {_bonus} bonus points!");
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
        if (IsComplete())
        {
            return $"[✓] {_shortName}, {_description}, status: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName}, {_description}, status: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal,{_shortName},({_description}),{_amountCompleted}/{_target},{IsComplete()},{_points},{_bonus}";
    }

}