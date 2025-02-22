using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(double laps, string activityName, int duration, string date) : base(activityName, duration, date)
    {   
        _laps = laps;
    }


    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60 ;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed() ;
    }


}