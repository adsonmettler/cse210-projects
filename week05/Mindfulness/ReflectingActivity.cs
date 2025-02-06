
using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        Console.WriteLine("\nThink about the following prompt:");
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);

        ShowSpinner(5); // Pause for 5 seconds

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.Write("\n" + Questions[random.Next(Questions.Count)] + " ");
            ShowSpinner(5); // Pause for 5 seconds
            elapsedTime += 5;
        }

        DisplayEndingMessage();
    }
}
