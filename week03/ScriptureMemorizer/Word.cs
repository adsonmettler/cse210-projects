

using System.Diagnostics.Contracts;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }
    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Methor do check if the word is hidden or not
    public bool IsHidden()
    {
        return _isHidden;
    }

    //Getter
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        return _text;
    }
}