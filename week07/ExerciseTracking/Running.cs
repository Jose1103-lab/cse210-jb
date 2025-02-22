using System;

public class Running : Activity
{
    private double _distance;

    public Running(double distance,  string activityName, int duration, string date) : base(activityName, duration, date)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _duration) * 60 ;
    }
    public override double GetPace()
    {
        return _duration / _distance;
    }


    
}