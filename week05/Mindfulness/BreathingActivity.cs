

using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4); // Pause for 4 seconds
            Console.Write("Breathe out...");
            ShowCountdown(4); // Pause for 4 seconds

            elapsedTime += 8; // 4 sec in + 4 sec out
        }

        DisplayEndingMessage();
    }
}
