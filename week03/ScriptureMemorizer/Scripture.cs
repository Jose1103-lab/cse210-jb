using System;
using System.Collections.Generic;
public class Scripture
{   
    private Reference _reference;
    private List<Word> _words;
    
//! getters and setters
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
//? Methods
    public void HideRamdonWords(int numberTohide)
    {

    }
    public string GetDisplayTextScrip()
    {
        return "is working";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}
