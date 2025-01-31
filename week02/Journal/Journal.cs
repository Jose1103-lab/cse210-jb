using System;
using System.IO;
using System.Collections.Generic;

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
            entry.Display();
        }
    }

    public void LoadFromFile (string fileToLoad)
    {
        try
        {
            string [] lines = System.IO.File.ReadAllLines(fileToLoad);                    
            Console.WriteLine("Loading journal...\n");  
            foreach (string line in lines)
            {
                Entry loadedentries = new Entry();      
                string[] loadedEntry = line.Split('|');
                loadedentries._date = ("." + loadedEntry[0]); //Exceeding: i added a point to date to avoid re-saving the same entry.
                loadedentries._title = loadedEntry[1];
                loadedentries._gottenPrompt = loadedEntry[2];
                loadedentries._entry = loadedEntry[3];

                AddEntry(loadedentries);
            }
        Console.WriteLine("Journal loaded!");
        }
        catch (Exception)
        {
            Console.WriteLine($"File '{fileToLoad}' doesn't exist.");
        }
    }

    public void SaveToFile (string fileToSave)
    {
        using (StreamWriter outputFile = new StreamWriter(fileToSave, true))
        {
            foreach (var entry in _entry)
                if (entry._date[0] != '.')
                {
                    outputFile.WriteLine($"{entry._date}|{entry._title}|{entry._gottenPrompt}|{entry._entry}");
                }
        }
        Console.WriteLine("Entries saved!");
    }

}