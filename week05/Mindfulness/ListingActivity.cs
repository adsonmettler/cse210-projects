

using System;
using System.Collections.Generic;
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

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        Console.WriteLine("\nPrompt: " + Prompts[random.Next(Prompts.Count)]);

        ShowCountdown(5); // Countdown before listing starts

        List<string> responses = new List<string>();
        int elapsedTime = 0;
        Console.WriteLine("\nStart listing items (press Enter after each item, type 'done' to finish):");

        while (elapsedTime < Duration)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            responses.Add(input);
            elapsedTime += 2; // Simulate time taken for each entry
        }

        Console.WriteLine($"\nYou listed {responses.Count} items.");
        DisplayEndingMessage();
    }
}
