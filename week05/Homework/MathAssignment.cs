using System;


public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";


    public MathAssignment(string name, string text, string textbook, string reason) : base(name, text)
    {
        _textbookSection = textbook;
        _problem = reason;
    }

    public string GetHomeworkList() => $"{GetSummary()}\n\nSection: {_textbookSection}\nProblems: {_problem}";
    
}
