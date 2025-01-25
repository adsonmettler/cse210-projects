


using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    // Constructor when is only one verse.
    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }
    // Constructor when there is a range of verses.
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Method to get reference string and display.
    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
        {
            // When is more than one verse
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            // When is only one verse
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}