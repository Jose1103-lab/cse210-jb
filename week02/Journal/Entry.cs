using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Entry 
{
    public string _title;
    public string _entry;
    public string _date;


    public void Display()
    {
        Console.WriteLine($"({_date}) {_title}");
        Console.WriteLine(_entry);
    }



}