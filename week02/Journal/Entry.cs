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
        Console.WriteLine($"({_date}) Title: {_title} \n<> {_gottenPrompt}\n> {_entry}");
        Console.WriteLine();
    }
    

}