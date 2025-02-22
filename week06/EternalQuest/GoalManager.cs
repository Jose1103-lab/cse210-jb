using System;

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
        if (_theme == "def"){Console.ResetColor();}
        else{Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), _theme, true);}

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
// exceeding requirement: I added the ability to save and load the goals as a profile by name 
            Console.WriteLine("[6] Load Profile");
            Console.WriteLine("[7] Exit");
            Console.WriteLine("");
            Console.Write("\nEnter an action: ");
            int switch_on = int.Parse(Console.ReadLine());
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
                Console.WriteLine($"{item.GetStringRepresentation()}");
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
                    _goals[goalIndex].RecordEvent();
                    Console.Write("Please wait ");
                    ShowSpinner();

                    Console.WriteLine("\n");
                    if (_goals[goalIndex].IsComplete())
                    {
                        Console.WriteLine("Congratulations the goal is completed!");
                    }
                    else { Console.WriteLine("Great Job! You are a step closer!!"); }

                    _score += _goals[goalIndex].GetPoints();
                    Console.WriteLine($"You have earned {_goals[goalIndex].GetPoints()} points!");
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

    }
    public void SaveGoal()
    {

    }
    private void ThemeStore()
    {

    }
     public void ShowSpinner()
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