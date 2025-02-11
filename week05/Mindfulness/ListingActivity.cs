using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questians;


    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
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
    public List<string> GetUserList()
    {
        
        return null; //! null is a placeholder
    }



}