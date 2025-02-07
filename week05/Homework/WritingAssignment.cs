using System;


public class WritingAssigment : Assignment
{
	private string _title;

    public WritingAssigment(string name, string text, string title) : base(name, text)
    {
        _title = title;
    }

	public string GetWritingInformation() => $"{GetSummary()}\n\nTitle: {_title}";

}
