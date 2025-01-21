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
        "How did you feel today?",
        "What are your goals for tomorrow?",
        "What is something you did well today?",
        "What is something you could improve on?",
        "What made you smile today?",
        "What challenges did you face today?",
        "How did you overcome those challenges?",
        "What is something new you tried today?",
        "What is a memorable moment from today?",
        "What are you looking forward to?",
        "What is something you are proud of?",
        "What is a goal you are working towards?",
        "What is something you are passionate about?",
        "What is a favorite memory from your childhood?",
        "What is something you want to achieve this year?",
        "What is a book you are currently reading?",
        "What is a movie or TV show you recently watched?",
        "What is a hobby you enjoy?",
        "What is something you are curious about?",
        "What is a place you want to visit?",
        "What is a skill you want to learn?",
        "What is something you appreciate about yourself?",
        "What is something you appreciate about others?",
        "What is a lesson you have learned recently?",
        "What is a piece of advice you would give to your younger self?",
        "What is a piece of advice you would give to your future self?",
        "What is something you are excited about?",
        "What is something you are worried about?",
        "What is something you are proud of accomplishing?",
        "What is a goal you have for the next month?",
        "What is a goal you have for the next year?",
        "What is something you want to change about your life?",
        "What is something you want to keep the same?",
        "What is a favorite quote or saying?",
        "What is something you are thankful for?",
        "What is a challenge you are currently facing?",
        "What is something you are looking forward to in the future?",
        "What is a favorite activity you enjoy doing?",
        "What is something you want to do more of?",
        "What is something you want to do less of?",
        "What is a habit you want to develop?",
        "What is a habit you want to break?",
        "What is something you are proud of in your personal life?",
        "What is something you are proud of in your professional life?",
        "What is a goal you have for your personal life?",
        "What is a goal you have for your professional life?",
    };
    
    // public List<string> _prompts;

    public string GetRandomPrompt(List<string> _prompts)
    {
        Random luck = new Random();
        string question = luck.(_prompts); 

        // foreach prompt in _prompts;
        return question;
    
    }
    
}