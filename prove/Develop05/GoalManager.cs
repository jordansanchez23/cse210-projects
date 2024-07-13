public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a number from 1 to 6.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName} - {_goals[i].GetStatusString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString() + $", Description: {goal.GetDescription()}");
        }
        DisplayPlayerInfo();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            return;
        }

        Goal newGoal = null;
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter goal points:");
        int points;
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid points value. Please enter a number.");
            return;
        }

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.WriteLine("Enter target count:");
                int target;
                if (!int.TryParse(Console.ReadLine(), out target))
                {
                    Console.WriteLine("Invalid target count. Please enter a number.");
                    return;
                }
                Console.WriteLine("Enter bonus points:");
                int bonus;
                if (!int.TryParse(Console.ReadLine(), out bonus))
                {
                    Console.WriteLine("Invalid bonus points. Please enter a number.");
                    return;
                }
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal have you accomplished?");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice. Please select a valid goal number.");
            return;
        }

        _goals[choice - 1].RecordEvent();
        _score += _goals[choice - 1].Points;

        if (_goals[choice - 1] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
            _score += checklistGoal.Bonus;
            Console.WriteLine($"Congratulations! You have earned {checklistGoal.Bonus} bonus points.");
        }

        Console.WriteLine($"Congratulations! You have earned {_goals[choice - 1].Points} points.");
        
        // The program shows progress after recording the event
        ShowProgress(_score, 1000); 
    }

    public void DisplayScoreboard()
    {
        Console.WriteLine("Current Score:");
        Console.WriteLine($"Total Points: {_score}");

        Console.WriteLine("Achieved Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.ShortName}: {goal.Points} points");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader inputFile = new StreamReader(filename))
            {
                _score = int.Parse(inputFile.ReadLine());
                _goals.Clear();
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Goal goal = null;
                    switch (parts[0])
                    {
                        case "Simple":
                            goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            break;
                        case "Eternal":
                            bool isComplete = bool.Parse(parts[4]);
                            goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            ((EternalGoal)goal).SetCompletionStatus(isComplete);
                            break;
                        case "Checklist":
                            goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]))
                            {
                                AmountCompleted = int.Parse(parts[4])
                            };
                            break;
                    }
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    public void ShowProgress(int currentScore, int totalScore)
    {
        Console.WriteLine("Progress:");
        Console.WriteLine($"Current Score: {currentScore}/{totalScore}");

        // The program calculates and display progress visually 
        double progressPercent = (double)currentScore / totalScore * 100;
        Console.WriteLine($"Progress: {progressPercent}%");

        // The bar representation
        int barLength = 20;
        int progressBars = (int)(progressPercent / (100.0 / barLength));
        Console.Write("[");
        for (int i = 0; i < barLength; i++)
        {
            if (i < progressBars)
                Console.Write("=");
            else
                Console.Write(" ");
        }
        Console.WriteLine($"] ({progressPercent}%)");
    }
}