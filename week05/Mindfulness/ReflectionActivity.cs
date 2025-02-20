using System;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
    // private string[] _p5rompts = new string[]
    // {
    private List<string> _prompts;
    private List<string> _questions;


    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "will guide you through thoughtful prompts to help you reflect on your experiences and gain insights.";
        _timeOfExecution = 10;
        _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Recall a moment when you helped someone in need.",
        "Remember a time when you achieved a significant goal.",
        "Think about a moment when you felt truly happy.",
        "Reflect on a time when you overcame a fear.",
        "Think of a moment when you made a new friend.",
        "Remember a time when you learned something new.",
        "Recall a moment when you felt proud of yourself."
        };
        _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When ready press Enter to start.");
        Console.ReadLine();

        DateTime timeOn = DateTime.Now;
        DateTime turnOff = timeOn.AddSeconds(_timeOfExecution);

        while (DateTime.Now < turnOff)
        {
            DisplayQuestion();
            Console.WriteLine("");
            Console.WriteLine("");
            // Thread.Sleep(_timeOfExecution / 2);
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        var selectPrompt = new Random();
        string chosen = _prompts[selectPrompt.Next(_prompts.Count)];

        return chosen;
    }

    public string GetRandomQuestion()
    {
        var selectQuestion = new Random();
        string chosen = _questions[selectQuestion.Next(_questions.Count)];

        return chosen;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Prompt: {GetRandomPrompt()}");

    }

    public void DisplayQuestion()
    {
        // string[] questions;       

        Console.Write($"Question 1: {GetRandomQuestion()}");
        ShowSpinner();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write($"Question 2: {GetRandomQuestion()}");
        ShowSpinner();
    }
}
