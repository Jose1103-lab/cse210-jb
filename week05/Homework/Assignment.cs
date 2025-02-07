using System;

public class Assignment
{
    private string _studentName;
    private string _text;


    public Assignment(string name, string text)
    {
        _studentName = name;
        _text = text;
    }
    public Assignment()
    {
        _studentName = "Unknown";
        _text = "NA";
    }

    public string GetSummary() => $"Student name: {_studentName}\nTopic:  {_text}";
    

}