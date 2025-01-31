using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _date;
    public string _title;
    public string _gottenPrompt;
    public string _entry;


    public void Display()
    {
// string thePrompt = _prompt.GetRandomPrompt();
        Console.WriteLine("--- Entries ---\n" + _gottenPrompt);
        Console.Write($"({_date}) \"{_title}\" " + _entry);
    }
    

}