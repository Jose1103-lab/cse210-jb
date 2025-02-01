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
        Console.WriteLine("--- Entries ---"); 
        foreach(Entry entry in _entry)
        {
            entry.Display();
        }
    }

    public void LoadFromFile (string fileToLoad)
    {
// i added exception handler just in case of a non-existing input is entered.
        try
        {
            string [] lines = System.IO.File.ReadAllLines(fileToLoad);                    
            Console.WriteLine("Loading journal...\n");  
            foreach (string line in lines)
            {
                Entry loadedentries = new Entry();      
                string[] loadedEntry = line.Split('|');
// Exceeding: i added a dot[.] to be placed before date to avoid re-saving the same entry 
// after the file is loaded; this feature does not affect the original file.
                loadedentries._date = ("." + loadedEntry[0]);
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
        // this condition saves all new entries, excluding those from the loaded file if it is loaded when entering a new one.
                if (entry._date[0] != '.')
                {
                    outputFile.WriteLine($"{entry._date}|{entry._title}|{entry._gottenPrompt}|{entry._entry}");
                }
        }
        Console.WriteLine("Entries saved!");
    }

}