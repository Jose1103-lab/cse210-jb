using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int wordHiddenCounter = 0;

    //! constructor
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
        var wordToHide = new Random();
        int word = 0;
        bool incrementerUsed = false;
        do
        {
            int index = wordToHide.Next(_words.Count);
            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                word += 1;
                wordHiddenCounter += 1;
            }
// This is used we have a non paired list
            if (wordHiddenCounter - GetListRange() == -1 && GetListRange() == wordHiddenCounter + 1 && incrementerUsed == false)
            {
                numberTohide += 1;
                incrementerUsed = true;
            }
// when the number of words to hide is reached 
            if (wordHiddenCounter == GetListRange())
            {
                break;
            }
// the condition here allows to hide 
        } while (word < numberTohide);

    }
    public string GetDisplayTextScrip()
    {
        Console.Clear();
        Console.WriteLine("Reference: " + _reference.GetDisplayTextRef());
        foreach (var wordtoshow in _words)
        {
            Console.Write(wordtoshow.GetDisplayTextW() + " ");
        }
        Console.WriteLine("\n\n");

        return "is working";
    }
    public bool IsCompletelyHidden()
    {
        if (wordHiddenCounter == _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
//Stretch: Using this method helps ensure that only visible words are selected.
    private int GetListRange()
    {
        return _words.Count;
    }
}
