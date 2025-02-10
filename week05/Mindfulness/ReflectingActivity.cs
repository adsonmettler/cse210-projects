

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

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
        {

        }

    public override void Run()
    {
        Console.Clear(); // Clear menu before displaying the activity
        DisplayStartingMessage();
        Random random = new Random();

        // Show prompt and wait for user to press Enter
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"\nThink about the following prompt:\n\"{prompt}\"");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue...");
        Console.ReadLine(); // Wait for user input

        Console.Clear(); // Clear prompt before showing reflection questions

        // Start showing reflection questions
        int elapsedTime = 0;
        int duration = GetDuration();

        Console.WriteLine("\nNow, consider these questions as you reflect:\n");

        while (elapsedTime < duration)
        {
            Console.Write("" + Questions[random.Next(Questions.Count)] + "\n");
            StartSpinner(10);
            elapsedTime += 10;
        }

        DisplayEndingMessage();
    }
}
