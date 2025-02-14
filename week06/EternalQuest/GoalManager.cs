
public class GoalManager
{
    // Attributes
    private List<Goal> _goals;
    private int _score;

    // Methods to manage Goals, record, save, load, and create menu.
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose a Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        
        string choice = Console.ReadLine();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target completions (numbers) until finish the goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record progress:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid selection!");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("\nWelcome to your Eternal Quest!\n ");
        Console.Write("\nEnter the filename to load goals and press enter,\n");
        Console.Write("if there is no file to load press enter: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0) return;

        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0].Trim();
            string name = parts[1].Trim();
            string description = parts[2].Trim();
            
            if (!int.TryParse(parts[3].Trim(), out int points))
            {
                Console.WriteLine($"Error parsing points from line: {lines[i]}");
                continue;
            }

            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4].Trim());
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                if (int.TryParse(parts[4].Trim(), out int amountCompleted) &&
                    int.TryParse(parts[5].Trim(), out int target) &&
                    int.TryParse(parts[6].Trim(), out int bonus))
                {
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                }
                else
                {
                    Console.WriteLine($"Error parsing checklist goal details from line: {lines[i]}");
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }



    public int GetScore()
    {
        return _score;
    }
}