using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;
        int duration = GetDuration();

        while (elapsedTime < duration)
        {
            Console.WriteLine("\nBreathe in...");
            StartCountdown(4);
            Console.WriteLine("Breathe out...");
            StartCountdown(6);

            elapsedTime += 10; // 4 sec in + 4 sec out
        }

        DisplayEndingMessage();
    }
}
