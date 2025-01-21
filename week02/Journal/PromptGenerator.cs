using System;
using System.Collections.Generic;
using System.Security.Cryptography;


public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What are you grateful for today?",
        "What was the highlight of your day?",
        "What did you learn today?",
        "How did you feel about the weather today?",
        "What is something you did well today?",
        "What is something you could improve on?",
        "What made you smile today?",
        "What challenges did you face today?",
        "What is something new you tried today?",
        "What is a memorable moment from today?",
        "What is a goal you have for your professional life?"
    };
    
    // public List<string> _prompts;

    public string GetRandomPrompt()
    {
        var luck = new Random();
        var question = luck.Next(_prompts.Count); 

        // foreach prompt in _prompts;
        return _prompts[question];
    
    }
    
}