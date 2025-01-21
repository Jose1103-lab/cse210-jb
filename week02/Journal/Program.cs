using System;

///Create an app that reminds or inspires users to record his experiences in a customized Journal 


class Program
{

    public class Journal{
        
    }

    static void Main(string[] args)
    {
        // List<string> test = new List<string>()
        // {
        //     "juanan0",
        //     "juanan2",
        //     "juanan1",
        //     "Pedro",
        //     "Matias"
        // };


        Console.WriteLine("Hello [Username], welcome to your journal.");
        Console.WriteLine();


    // Main menu 
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Exit.");
        Console.Write("Enter an option: ");
        try
        {
        int choice = int.Parse(Console.ReadLine());
    // Menus execution 
        switch (choice)
        {
            case 1:
                Console.WriteLine("Case 1");
                PromptGenerator question = new PromptGenerator();
                Console.WriteLine(question.GetRandomPrompt());
                break;
            case 2:
                Console.WriteLine("Case 2");
                break;
            case 3:
                Console.WriteLine("Case 3");
                break;
            case 4:
                Console.WriteLine("Case 4");
                break;
            case 5:
                break;
            default:
                break;
        }

        }
        catch(FormatException ex)
        {
            Console.WriteLine($"Ups! Something unexpected happened. ({ex.Message})");
        };
        // finally
        // {
        //     Console.WriteLine("Try running the program again.");
        // };


    

    }
}