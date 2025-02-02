using System;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

//! Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

//? Methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

// Exceeding:  I added an algorithm to avoid changing punctuation marks and it will be a hint to the user
//  so they can focus specifically on the words even if they count the spaces it will be easier.
    public string GetDisplayTextW()
    {
        if(_isHidden) 
        {
            StringBuilder replacementBuilder = new StringBuilder();
            string[] punctuationMarks = { ",", ".", ":", ";", "!", "?", "-", "(", ")", "'", "_", "/","\""};
            foreach(var letter in _text)
            {
                string value = letter.ToString();
                if(punctuationMarks.Contains(value))
                {
                    replacementBuilder.Append(value);
                }
                else
                {
                    replacementBuilder.Append('_');
                } 
            }
            
            string replacement = replacementBuilder.ToString();
            return replacement;
        }
        else
        {
            return _text;
        }
    }
}