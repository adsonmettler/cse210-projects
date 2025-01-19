using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filePath = "journal.txt";

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Please, select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Write an Entry
                    string randomPrompt = promptGenerator.GetRandomPrompt(); // Get a random prompt
                    Console.WriteLine($"\nPrompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    // Create a new entry
                    string currentDate = DateTime.Now.ToString("yyyy/MM/dd");
                    Entry newEntry = new Entry(currentDate, randomPrompt, response);
                    journal.AddEntry(newEntry);
                    break;

                case "2": // Display Entries
                    journal.Display();
                    break;

                case "3": // Save to File
                    Console.Write("Enter the file name to save the journal (e.g., journal.txt): ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "4": // Load from File
                    Console.Write("Enter the file name to load the journal (e.g., journal.txt): ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "5": // Exit
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}