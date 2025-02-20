using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _timeOfExecution;

    public Activity()
    {
        _name = "";
        _description = "";
        _timeOfExecution = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"[User], welcome to your daily {_name} activity!");
        Console.WriteLine();
        Console.WriteLine($"The {_name} activity {_description}");
        Console.WriteLine();
        Console.Write("For how long in (seconds) would you like to perform this activity? ");
        _timeOfExecution = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready...");
        ShowCountDown();
        Console.Clear();
        Console.WriteLine($"~ {_name} activity ~");
        Console.WriteLine();

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great Job!");
        ShowSpinner();
        Console.WriteLine($"You completed {_timeOfExecution} seconds more of your {_name} actity!");
        ShowSpinner();

    }
    public void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        for (int i = 0; i <= 7; i++)
        {
            // if (i >= 7) i = 0; //infite spinner
            Console.Write(spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }

    }
    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }
        Console.WriteLine("");
    }
}