using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _theme;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _theme = "def";
    }

    public void Start()
    {
        bool running = true;
        // _theme = "Green"; //! Testing
   
        while (running)
        {
            Console.Clear();
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦¤¤¤¤¤¤♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("♥ Welcome to Eternal Quest ♥");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦¤¤¤¤¤¤♦♦♦♦♦♦♦♦♦♦♦");

            Console.Write("Your score: ");
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("[1] See my goals");
            Console.WriteLine("[2] Create new goal");
            Console.WriteLine("[3] Record an event");
// exceeding requiremnent: I added store where the user can buy a color theme for the console
            Console.WriteLine("[4] Store");
            Console.WriteLine("[5] Save");
            Console.WriteLine("[6] Load");
            Console.WriteLine("[7] Exit");
            Console.WriteLine("");
            Console.Write("\nEnter an action: ");
            int switch_on = 0;
            while (!int.TryParse(Console.ReadLine(), out switch_on) || switch_on < 1 || switch_on > 7)
            {
                Console.WriteLine("Invalid input, please enter a number within the range");
            }

            Console.Clear();

            switch (switch_on)
            {
                case 1: { ListGoalNames(); break; }
                case 2: { CreateGoal(); break; }
                case 3: { RecordGoal(); break; }
                case 4: { ThemeStore(); break; }
                case 5: { SaveGoal(); break; }
                case 6: { LoadGoal(); break; }
                case 7: { running = false; break; }
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }
    public void ListGoalNames()
    {
        Console.WriteLine("♦ Your Goals ♦\n");

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals!\n");
        }
        else
        {
            foreach (Goal item in _goals)
            {
                Console.WriteLine($"{item.GetDetailsString()}");
            }
        }
        Console.Write("\nPress Enter to exit.");
        Console.ReadLine();
    }
    public void ListGoalDetails()
    {

        Console.WriteLine("♦ Your Goals' Status ♦\n");

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals!\n");
        }
        else
        {
            foreach (Goal item in _goals)
            {
                Console.WriteLine($"{item.GetStringRepresentation()}");
            }
        }
        Console.Write("Press Enter to exit.");
        Console.ReadLine();
    }
    public void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("select the type of goal you want to create");
        Console.WriteLine("[1] CheckList Goal");
        Console.WriteLine("[2] Eternal Goal");
        Console.WriteLine("[3] Simple Goal");
        Console.Write("\nEnter your option: ");
        int option = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.Write("Enter the title of the goal: ");
        string title = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points is this goal worth? ");
        int score = int.Parse(Console.ReadLine());

        Goal newGoal = null;
        switch (option)
        {
            case 1:
                {
                    Console.Write("Enter target for completition: ");
                    int target = 0;
                    while (!int.TryParse(Console.ReadLine(), out target) || target <= 0)
                    {
                        Console.WriteLine("Invalid input, please enter a number");
                    }
//i automatically added a bonus based on the points and target submitted value
                    int bonus = score * (int)Math.Pow(target, 2); 
                    Console.WriteLine($"When this goal is completed you will obtain {bonus} points");
                    
                    newGoal = new CheckListGoal(title, description, score, target, bonus);
                    break;
                }
            case 2:
                {newGoal = new EternalGoal(title, description, score); break;}
            case 3:
                {newGoal = new SimpleGoal(title, description, score, false); break;}
            default:
                {Console.WriteLine("Invalid option"); break;}
        }

        _goals.Add(newGoal);
        Console.Write("\nPlease wait ");
        ShowSpinner();
        Console.WriteLine("Goal created!");
        Console.Write("\nPress Enter to exit.");
        Console.ReadLine();

    }
    public void RecordGoal()
    {
        Console.WriteLine("♦ Record an Event ♦\n");

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals!\n");
        }
        else
        {
            Console.WriteLine("Select a goal to record an event for: \n");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
            while (true)
            {
                Console.Write("\nEnter the number of the goal: ");
                try
                {
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Please wait ");
                    ShowSpinner();
                    _goals[goalIndex].RecordEvent();

                    Console.WriteLine("\n");
                    _score += _goals[goalIndex].GetPoints();
                    Console.WriteLine($"You have earned {_goals[goalIndex].GetPoints()} total points!");
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Invalid input, please enter a number within the range");
                }
            }
        }
        Console.Write("\nPress Enter to exit.");
        Console.ReadLine();

    }
    public void LoadGoal()
    {
        Console.WriteLine("♦ Load Goals ♦\n");

        Console.WriteLine("Enter the name of the file to load the goals");
        string fileName = Console.ReadLine();
        Console.WriteLine("Please wait ");
        ShowSpinner();
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string[] scoreAndTheme = reader.ReadLine().Split(",");
                _score = int.Parse(scoreAndTheme[0]);
                _theme = scoreAndTheme[1];
                while (!reader.EndOfStream)
                {
                    string[] goalData = reader.ReadLine().Split(",");
                    switch (goalData[0])
                    {
                        case "CheckList Goal":
                            {
                                _goals.Add(new CheckListGoal(goalData[1], goalData[2], int.Parse(goalData[4]), int.Parse(goalData[3]), int.Parse(goalData[5])));
                                break;
                            }
                        case "Eternal Goal":
                            {
                                _goals.Add(new EternalGoal(goalData[1], goalData[2], int.Parse(goalData[4])));
                                break;
                            }
                        case "Simple Goal":
                            {
                                _goals.Add(new SimpleGoal(goalData[1], goalData[2], int.Parse(goalData[4]), bool.Parse(goalData[3])));
                                break;
                            }
                    }
                }
            }
            if (_theme == "def"){Console.ResetColor();}
            else{Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), _theme, true);}

            Console.WriteLine("\nFile loaded successfully!");

        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.Write("\nPress Enter to exit.");
        Console.ReadLine();

    }
    public void SaveGoal()
    {   
        Console.WriteLine("♦ Save Goals ♦\n");

        Console.WriteLine("Enter the name of the file to save the goals");  
        string fileName = Console.ReadLine();
        Console.WriteLine("Please wait ");  
        ShowSpinner();
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"{_score},{_theme}");
                foreach (Goal item in _goals)
                {
                    writer.WriteLine(item.GetStringRepresentation());
                }
            }
            Console.WriteLine("\nFile saved successfully!");
        }
        catch (System.Exception e)
        {
            Console.WriteLine($"An error occurred while saving the file: {e}");
        }

        Console.Write("\nPress Enter to exit.");
        Console.ReadLine();
    }
//exceeding requirement: I added a store where the user can buy a color theme for the console
    private void ThemeStore()
    {  
// a future feature to be added is to save the theme selected by the user so they can select 
// it from a settings menu because actually the theme is only applied to the console window 
// and not saved in a list
        Console.WriteLine("♦ Theme Store ♦\n");
        Console.WriteLine("Select a theme to purchase");

        Console.WriteLine("[1] Green..........(2500 Points)");
        Console.WriteLine("[2] Blue...........(5000 Points)"); 
        Console.WriteLine("[3] Purple.........(1500 Points)"); 
        Console.WriteLine("[5] Light Aqua.....(15000 Points)");
        Console.WriteLine("[6] Light Yellow...(10000 Points)"); 

        Console.Write("\nEnter your option: ");
        try
        {
            _theme = PurchaseTheme(_score, _theme);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Invalid input, please enter a number within the range");
        }
    }
    private string PurchaseTheme(int score, string theme)
    {
        theme = "def";
        int option = int.Parse(Console.ReadLine());
        while (option != 1 && option != 2 && option != 3 && option != 4 && option != 5)
        {
            Console.WriteLine("Invalid input, please enter a number within the range");
            option = int.Parse(Console.ReadLine());
        }
        switch (option)
        {
            case 1:
                {
                    if (score >= 2500)
                    {
                        _score -= 2500;
                        theme = "Green";
                        Console.WriteLine("Theme purchased!");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough points to purchase this theme");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                }
            case 2:
                {
                    if (score >= 5000)
                    {
                        _score -= 5000;
                        theme = "Blue";
                        Console.WriteLine("Theme purchased!");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough points to purchase this theme");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                }
            case 3:
                {
                    if (score >= 1500)
                    {
                        _score -= 1500;
                        theme = "Magenta";
                        Console.WriteLine("Theme purchased!");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough points to purchase this theme");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                }
            case 4:
                {
                    if (score >= 10000)
                    {
                        _score -= 10000;
                        theme = "Cyan";
                        Console.WriteLine("Theme purchased!");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough points to purchase this theme");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                }
            case 5:
                {
                    if (score >= 15000)
                    {
                        _score -= 15000;
                        theme = "Yellow";
                        Console.WriteLine("Theme purchased!");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough points to purchase this theme");
                        Console.Write("\nPress Enter to exit.");
                        Console.ReadLine();
                        return theme;
                    }
                }
            default:
                {
                    Console.WriteLine("Invalid option");
                    return theme;
                    // break;
                }
        }

    }
    private void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");

        for (int i = 0; i <= 4; i++)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}