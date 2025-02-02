using System;
using System.Collections.Generic;
public class Comment
{
    private string _commenterName;
    private string _text;

// constructor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }
// methods
    public string GetText()
    {
        return _text;
    }
    public string GetCommenterName()
    {
        return _commenterName;
    }

}

