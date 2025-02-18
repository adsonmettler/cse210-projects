using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            

            GoalManager goalManager = new GoalManager(); // Create instance of GoalManager
            goalManager.LoadGoals(); // Load saved goals and points

            while (true)
            {
                Console.Clear(); // Clears previous activity screen before displaying menu
                Console.WriteLine($"\nYou have {goalManager.GetScore()} points.\n"); // Display current points

                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option from the menu (type a number): ");

                string option = Console.ReadLine();
                Console.Clear(); // Clears menu once an activity is selected

                switch (option)
                {
                    case "1":
                        goalManager.CreateGoal();
                        break;
                    case "2":
                        goalManager.ListGoalNames();
                        //goalManager.ListGoalDetails();
                        break;
                    case "3":
                        goalManager.SaveGoals();
                        break;
                    case "4":
                        goalManager.LoadGoals();
                        break;
                    case "5":
                        goalManager.RecordEvent();
                        break;
                    case "6":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}