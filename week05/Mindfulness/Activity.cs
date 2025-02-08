using System;
using System.Threading;

public abstract class Activity
{
    private string Name;
    private string Description;
    private int Duration;

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

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Duration = duration;
        }
        else
        {
            Duration = 30; // Default to 30 seconds
        }

        Console.Clear(); // Clears

        Console.WriteLine("\nPrepare to begin...");
        StartSpinner(3);
        Console.Clear(); // Clears
    }

    public void DisplayEndingMessage()
    {
        Console.Clear(); // Clears
        Console.WriteLine("\nGreat job! You've completed the activity.");
        Console.WriteLine($"You completed {Name} for {Duration} seconds.");
        StartSpinner(3);
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}...  ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.WriteLine("\n");
    }

    protected void StartCountdown(int seconds) => ShowCountdown(seconds);
    protected void StartSpinner(int seconds) => ShowSpinner(seconds);

    protected int GetDuration() => Duration;

    public abstract void Run();
}
