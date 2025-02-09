using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();

        Console.WriteLine("\nPrompt: " + Prompts[random.Next(Prompts.Count)]);
        StartCountdown(5); // Pause before user starts listing

        List<string> responses = new List<string>();
        int duration = GetDuration();

        Console.WriteLine("\nStart listing items (press Enter after each item). You have limited time!");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // Loop to allow user input items on a list
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }

        stopwatch.Stop();

        Console.WriteLine($"\nTime's up! You listed {responses.Count} items.");
        DisplayEndingMessage();
    }
}
