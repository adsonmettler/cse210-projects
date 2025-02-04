
using System.Diagnostics.Contracts;
using System.Net;

public class Book
{
    private string _author = "";
    private string _title = "";

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetBookInfo()
    {
        return $"{_title} by {_author}";
    }
}