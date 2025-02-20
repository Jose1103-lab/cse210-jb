using System;

public abstract class Activity
{
    private string _activityName;
    private int _duration;
    private string _date;
    
    public Activity(string activityName, int duration, string date)
    {
        _activityName = activityName;
        _duration = duration;
        _date = date;
    }


    
}