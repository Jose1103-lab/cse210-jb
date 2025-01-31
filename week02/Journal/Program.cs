using System;
using System.IO;

/// Objective: Create an app that reminds or inspires users to record his experiences in a customized Journal 
/// 
/// I added some exceeding features in the jouunal and the entry file please see the comments there.
/// 
/// here I added a exception handler to avoid unexpected behaviors. 
/// 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        bool loopIsOn = true;
        Journal newEntry = new Journal();
//* Main menu 
        while(loopIsOn)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Hello [Username], welcome to your journal.");
                Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Exit.");
                Console.Write("Enter an option: ");
//* Menus execution 
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                //! instantiating the objects
                        Entry newLine = new Entry(); 
                        PromptGenerator prompt = new PromptGenerator();
                //! getting the information for the new journal entry
                        DateTime currentTieme = DateTime.Now;
                        string dateNow = currentTieme.ToShortDateString();
                        newLine._date = dateNow;
                        newLine._gottenPrompt = prompt.GetRandomPrompt();  
                        Console.Write("How will you title your day? \n>_ ");
                        newLine._title = Console.ReadLine();
                        Console.Write($"\n{newLine._gottenPrompt}\n>_ ");
                        newLine._entry = Console.ReadLine();
                        
                //! displaying the entry 
                //! storing the entry in the new journal instance
                //! printing the output out
                        Console.WriteLine("");
                        newEntry.AddEntry(newLine);
                        Console.Write("\n\nPress ENTER to continue... ");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Displaying all entries...");
                        newEntry.DisplayAll();

                        Console.Write("\nPress ENTER to continue... ");
                        Console.ReadLine();
                        break;
                    case 3:
                // string filename2load = "myJournal.txt"; -- I firstly created a algorithm that save and load a default filename
                        Console.WriteLine("Enter your file's name: ");
        // Exceeding: I added automation here to save the file as [.txt] by default it would be more user friendly
        // so when loading the file the user doesn't have to worry about the file type, in the future I will change 
        // it to a Json so I can easily use it with a website.
                        string fileName2Load = (Console.ReadLine() + ".txt");
                        newEntry.LoadFromFile(fileName2Load);
                        
                        Console.Write("\nPress ENTER to continue... ");
                        Console.ReadLine();
                        break;
                    case 4:
                // string filename2save = "myJournal.txt";
                        Console.WriteLine("Enter your new file's name: ");
                        string fileName2Save = (Console.ReadLine() + ".txt");
                        newEntry.SaveToFile(fileName2Save);

                        Console.Write("\nPress ENTER to continue... ");
                        Console.ReadLine();
                        break;
                    case 5:
                        loopIsOn = false;
                        Console.WriteLine("Your journal loves you. ♥");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please enter a number between 1 and 5.");
                        Console.Write("\n\nPress ENTER to continue... ");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Ups! Something unexpected happened. ({ex.Message})");
                Console.Write("\n\nPress ENTER to continue... ");
                Console.ReadLine();
                continue;
            };
        }
    }
}