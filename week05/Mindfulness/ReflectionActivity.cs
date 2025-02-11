using System;

public class ReflectionActivity : Activity
{
    private int _count; 
    private int _prompts; 



    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

    }
        public string GetRandomPrompt()
    {
        
        return"";
    }
    public string GetRandomQuestion()
    {

        return"";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {

    }
}