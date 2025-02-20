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
        if (_theme == "def")
        {
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), _theme, true);
        }

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
            Console.WriteLine("[4] Store"); // exceeding requiremnent: I added store where the user can buy a color themne
            Console.WriteLine("[5] Save");
            Console.WriteLine("[6] Load");
            Console.WriteLine("[7] Exit");
            Console.WriteLine("");
            Console.Write("\nEnter an action: ");
            int switch_on = int.Parse(Console.ReadLine());

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
        Console.Clear();
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
        Console.Write("Press Enter to exit.");
        Console.ReadLine();
    }

    public void ListGoalDetails()
    {

        Console.Clear();
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
        Console.Write("Enter the title of the goal: ");
        string title = Console.ReadLine();
        Console.Write("\nEnter the description of the goal");
        string description = Console.ReadLine();

        Console.WriteLine("select the type of goal you want to create");
        Console.WriteLine("[1] CheckList Goal");
        Console.WriteLine("[2] Eternal Goal");
        Console.WriteLine("[3] Simple Goal");

        Goal newGoal = null;
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    Console.WriteLine("Enter target for completition: ");
                    int target = 0;
                    while (!int.TryParse(Console.ReadLine(), out target) || target <= 0)
                    {
                        Console.WriteLine("Invalid input, please enter a number");
                    }

                    newGoal = new CheckListGoal(title, description, 50, target, 200);
                    break;
                }
            case 2:
                {
                    newGoal = new EternalGoal(title, description, 100);
                    break;
                }
            case 3:
                {
                    newGoal = new SimpleGoal(title, description, 150, false);
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid option");
                    break;
                }
        }
        _goals.Add(newGoal);


    }
    public void RecordGoal()
    {
        Console.Clear();
        Console.WriteLine("♦ Record an Event ♦\n");

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals!\n");
        }
        else
        {
            Console.WriteLine("Select a goal to record an event for: ");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {_goals[i].GetDetailsString()}");
            }
            Console.Write("\nEnter the number of the goal: ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Enter the event: ");
            string eventDescription = Console.ReadLine();

            _goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded!");
        }
        Console.Write("Press Enter to exit.");
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


}