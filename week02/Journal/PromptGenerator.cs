public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What scripture I kept in mind from my daily scripture time?",
        "What was the best part of my day?",
        "How did I see the Lord's hand in my life today?",
        "What was the most important accomplishment of the day?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}