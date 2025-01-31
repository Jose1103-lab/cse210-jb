using System;
using System.Collections.Generic;
class Comment
{
    private string _commenterName;
    private string _text;
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }
    public string GetCommenterName()
    {
        return _commenterName;
    }

}

