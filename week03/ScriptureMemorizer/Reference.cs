using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //! getters and setters 
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = firstVerse;
        _endVerse = lastVerse;
    }

    //? Methods 
    public string GetDisplayTextRef()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}