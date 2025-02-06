
using System;
using System.Threading;

public abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nStarting {Name}...");
        Console.WriteLine(Description);
        Console.Write("\nEnter duration (in seconds): ");
        
        // Get user input for duration
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration;
        }
        else
        {
            Duration = 30; // Default to 30 seconds
        }

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3); // Show a spinner for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You've completed the activity.");
        Console.WriteLine($"You completed {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in {i}...  ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.WriteLine("\n");
    }

    public abstract void Run();
}
