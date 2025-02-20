using System;

public class BreathingActivity : Activity
{


    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "will guide you through a series of deep breathing exercises to help you relax and focus.";
        _timeOfExecution = 10;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DateTime timeOn = DateTime.Now;
        DateTime turnOff = timeOn.AddSeconds(_timeOfExecution);

        while (DateTime.Now < turnOff)
        {
            Console.Write("Breathe in...");
            ShowCountDown();
            Console.Write("Now breathe out...");
            ShowCountDown();
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }

}