public class GoalManager
{
    protected List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;

                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {   
        Console.WriteLine("Eternal Quest - Goal Manager");
        foreach (var goal in _goals)
        {
            _score += goal._points;
        }
        Console.WriteLine($"Your score: {_score}");
        Console.WriteLine("Your goals: ");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points: ");
        string points = Console.ReadLine();


        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        Goal newGoal = null;
        switch(choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, int.Parse(points));
                break;
            case "2":
                newGoal = new EternalGoal(name, description, int.Parse(points));
                break;
            case "3":
                Console.WriteLine("Enter target completion count: ");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points:");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, int.Parse(points), target, bonus);
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                break;
        }
        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully.");
        }
    }
    public void RecordEvent()
    {
        // Ask user which goal they have done and record the event
        Console.WriteLine("Select goal to record event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= _goals.Count)
        {
            _goals[choice - 1].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
    public void SaveGoals()
    {
        // Save list of goals to a file
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        // Load list of goals from a file
        _goals.Clear(); // Clear existing goals
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                if (parts.Length == 4)
                {
                    _goals.Add(new SimpleGoal(name, description, points));
                }
                else if (parts.Length == 5)
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (parts.Length == 6)
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
    public void ListGoalNames()
    {
        // List names of each goal
        Console.WriteLine("List of Goal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal._name);
        }
    }




























    public void DisplayMenu()
    {
            Console.WriteLine("Eternal Quest - Goal Manager");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Select an option: ");
    }



}