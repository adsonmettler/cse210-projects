
using System.Reflection;

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
                newGoal = new SimpleGoal(name, description, points, false);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target completions (numbers) until finish the goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, 0, target, bonus);
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
        Console.WriteLine("Select a goal (number) to record progress:");
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
        string directoryPath = @"C:\adson-root\byu-software-dev\cse210-projects\week06\EternalQuest\bin\Debug\net8.0\";

        Console.Write("Enter the filename (without extension): ");
        string filename = Console.ReadLine()?.Trim();

        // Validate input and ensure .txt extension
        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Invalid filename. Using default: goals.txt");
            filename = "goals.txt";
        }
        else
        {
            filename += ".txt";
        }

        string filePath = Path.Combine(directoryPath, filename);

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved successfully in: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }


    public void LoadGoals()
    {
        Console.Write("\nWelcome to your Eternal Quest!\n ");
        Console.Write("\nEnter the filename to load goals (or press enter to use default): ");
        
        string filename = Console.ReadLine();
        string directoryPath = @"C:\adson-root\byu-software-dev\cse210-projects\week06\EternalQuest\bin\Debug\net8.0\";

        
        
        // If the user enters nothing, use a default file location
        if (string.IsNullOrWhiteSpace(filename))
        {
            filename = @"C:\adson-root\byu-software-dev\cse210-projects\week06\EternalQuest\bin\Debug\net8.0\goals.txt";
        }

        string filePath = Path.Combine(directoryPath, filename); // Combine the directory with the filename

        // Verify if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"No saved goals found at: {filePath}");
            return;
        }


        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0) return;

        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(new[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string type = parts[0].Trim();
            string name = parts[1].Trim();
            string description = parts[2].Trim();
            
            if (!int.TryParse(parts[3].Trim(), out int points))
            {
                Console.WriteLine($"Error parsing points from line: {lines[i]}");
                continue;
            }

            if (type == "Simple Goal")
            {
            if (!bool.TryParse(parts[4].Trim(), out bool isComplete))
            {
                Console.WriteLine($"Error parsing boolean value from line: {lines[i]}");
                continue;
            }
            _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (type == "Eternal Goal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "Checklist Goal")
            {
                if (parts.Length < 7) 
                {
                    Console.WriteLine($"Error parsing checklist goal details from line: {lines[i]}");
                    continue;
                }

                string[] progressParts = parts[4].Trim().Split('/'); // Split "0/4" into ["0", "4"]

                if (progressParts.Length != 2 || 
                    !int.TryParse(progressParts[0], out int amountCompleted) ||
                    !int.TryParse(progressParts[1], out int target) ||
                    !int.TryParse(parts[5].Trim(), out int bonus))
                {
                    Console.WriteLine($"Error parsing checklist goal details from line: {lines[i]}");
                    continue;
                }

                _goals.Add(new ChecklistGoal(name, description, points, amountCompleted, target, bonus));
            }

        }
        
    }



    public int GetScore()
    {
        return _score;
    }
}