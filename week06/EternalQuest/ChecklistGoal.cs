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

    }

    public override bool IsComplete()
    {
        return true; //placeholder 
    }

    public override string GetDetailsString()
    {
        return $"Goal: {_shortName}, Description: {_description}, Score: {_points}";
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName}, {_description}";
    }



}