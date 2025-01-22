using System;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();


    public void AddEntry (Entry newEntry)
    {
        _entry.Add(newEntry);
    }

    public void DisplayAll ()
    {
        foreach(Entry entry in _entry)
        {
            Console.WriteLine(entry);
        }
    }

    public void LoadFromFile (string fileToLoad)
    {

    }

    public void SaveToFile (string fileToSave)
    {

    }


}