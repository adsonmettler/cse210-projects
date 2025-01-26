
public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();

    // Constructor
    public Scripture(string reference, string text)
    {
        _reference = reference;
        
        // This is to split text into words and create Word objects.
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // This method is to hide the amount of random words specified in the Main Program class.
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        // Randomly select words to hide.
        Random random = new Random();
        int count = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();

            // Needed to prevent hiding the same word twice.
            visibleWords.RemoveAt(index);
        }
    }
    
    // Method to get the scripture text with hidden words, which is replaced by underscores.
    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }

    // Method to check if all words are hide, then the program can be ended.
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}