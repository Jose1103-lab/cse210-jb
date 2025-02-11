using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _timeOfExecution;



    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _timeOfExecution = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"[User], welcome to your daily {_name} activity!");
        Console.WriteLine();        
        Console.WriteLine($"The {_name} activity {_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
    }
    public void ShowSpinner()
    {

    }
    public void ShowCountDown()
    {

    }
    

}