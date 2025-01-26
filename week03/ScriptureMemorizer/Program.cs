using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 7);

        Scripture scripture = new Scripture(reference.GetDisplayText(),
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. "+
        "In all thy ways acknowledge him, and he shall direct thy paths. "+
        "Be not wise in thine own eyes: fear the Lord, and depart from evil.");

        Console.WriteLine("Welcome to the Scripture Memorizer!");

        // Loop for user to interact hiting enter
        while (true)
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! You memorized all. Well done!");
                break;
            }

            Console.WriteLine("\nPress enter to hide 2 more words, or type 'quit' to exit.");
            string userInput = Console.ReadLine()?.Trim().ToLower();

            if (userInput == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Hide 2 more words
            scripture.HideRandomWords(2);
        }
    }
}