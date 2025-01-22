using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _date;
    public string _title;
    public string _gotPrompt;
//public PromptGenerator _prompt = new PromptGenerator();
    public string _entry;


    public void Display()
    {
// string thePrompt = _prompt.GetRandomPrompt();
        Console.Write($"({_date}) \"{_title}\" ");
        Console.WriteLine(_entry + "\n> " + /*thePrompt +*/  "\n> ");

    }



}