using System;

public class Cycling : Activity
{
    public double _speed;

    public Cycling(double speed,  string activityName, int duration, string date) : base(activityName, duration, date)
    {   
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _duration / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }

    
}