using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _date;
// Exceeding: I added a new entry <title> so users can save their stories and title them.
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