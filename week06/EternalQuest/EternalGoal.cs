using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {
        _shortName = name;
        _description = description;
        _points = point;

    }

    public override void RecordEvent()
    {
        Console.WriteLine("Great Job! You are a step closer!!"); 
    }

    public override bool IsComplete()
    {
        return false;  
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal,{_shortName},{_description},{IsComplete()},{_points}";
    }



}