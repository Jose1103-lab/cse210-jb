using System;
using System.Diagnostics;
using System.Security.Authentication;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "will help you list and reflect on positive aspects of your life to enhance mindfulness and gratitude.";
        _timeOfExecution = 20;
        _count = 0;
        _prompts = new List<string>{
            "What is a moment when you felt at peace?",
            "Can you think of a time when you made someone smile?",
            "When did you feel proud of a friend?",
            "What is a time when you learned something valuable?",
            "When did you feel truly appreciated?",
            "Can you remember a time when you helped someone achieve their goal?",
            "What is a moment when you felt connected to nature?",
            "When did you show kindness to a stranger?",
            "What is a moment when you felt inspired?",
            "Can you think of a time when you overcame a challenge?",
            "When did you feel grateful for your family?"
        };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
        GetUserList();

        Console.WriteLine("");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        var selectPrompt = new Random();
        string chosen = _prompts[selectPrompt.Next(_prompts.Count)];

        return chosen;
    }
    public List<string> GetUserList()
    {
        List<string> userResponses = new List<string>();

        DateTime timeOn = DateTime.Now;
        DateTime turnOff = timeOn.AddSeconds(_timeOfExecution);

        while (DateTime.Now < turnOff)
        {
            Console.Write(">_ ");
            string userEntry = Console.ReadLine();
            userResponses.Add(userEntry);
            _count++;
        }
        Console.WriteLine($"You listed {_count}");
        return userResponses;
    }



}