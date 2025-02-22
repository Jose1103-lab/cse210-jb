using System;

public abstract class Activity
{
    protected string _activityName;
    protected int _duration;
    protected string _date;
    
    public Activity(string activityName, int duration, string date)
    {
        _activityName = activityName;
        _duration = duration;
        _date = date;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    public string GetSummary()
    {
        return $"{_date} - {_activityName} ({_duration} min) - Distance: {Math.Round(GetDistance(),2)} km, Speed: {Math.Round(GetSpeed(),2)} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }



    
}