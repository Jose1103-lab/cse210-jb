using System;
using System.Data;
using System.IO;
// Exceeding: I added some exceeding features please see comments in Word and here as well.

class Program
{
// I declared a fucntion to extract a random scripture from a file 
    static string[] ScriptureGetter(string fileName)
    {
        try
        {
            string[] database = System.IO.File.ReadAllLines(fileName);
            var ramdSelection = new Random();
            var i = ramdSelection.Next(database.Length);
            string[] value = database[i].Split("|");

            return value;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }

        return null;
    }

// I declared a fucntion to create the reference using the output of the function above 
    static Reference ReferenceBuilder(string[] quote)
    {
        var lastchapter = quote[2].Split("-");  // to split the reference chapter 
        if (lastchapter.Length == 2) // if there is something to split the list will take a second index
        {
            return new Reference(quote[0], int.Parse(quote[1]), int.Parse(lastchapter[0]), int.Parse(lastchapter[1]));
        }
        else
        {
            return new Reference(quote[0], int.Parse(quote[1]), int.Parse(lastchapter[0]));
        }
    }

    static void Main(string[] args)
    {
        try
        {
            string[] currentQuote = ScriptureGetter("scriptures.txt");
            Reference references = ReferenceBuilder(currentQuote);

            Console.WriteLine("Week-3 Project -- scriptures memorizer --");
    // constructors to instantiate the objects.    
        //Exceeding:    Reference references = new Reference("Proverbs", 3, 5, 6); // I changed this to be loaded from a file
            Scripture newGame = new Scripture(references, currentQuote[3]);

    // variables needed to run the program.    
            bool gameOn = true;
            while (gameOn)
            {
                newGame.GetDisplayTextScrip();
                newGame.HideRamdonWords(2);

    //Program killer 
                Console.Write("Press ENTER to continue or type QUIT to stop >_ ");
                string runningOn = Console.ReadLine();
                if (runningOn.ToLower() == "quit" || newGame.IsCompletelyHidden())
                {
                    newGame.GetDisplayTextScrip();
                    Console.WriteLine("Now your are a scriptures master!");
                    gameOn = false;
                }
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Something unexpected happended, make sure that 'scriptures.txt' is in the same folder");
        }
    }
}