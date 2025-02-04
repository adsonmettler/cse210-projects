


using System.Data;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    // Public Getters and Setters
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Length
    {
        get { return _length; }
        set 
        {
            if (value > 0)
            {
                _length = value;
            }
            else
            {
                throw new ArgumentException("Length must be greater than zero.");
            }
        }
    }

    public List<Comments> Comments
    {
        get { return _comments; }
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to add a comment
    public void AddComment(Comments comment)
    {
        Comments.Add(comment);
    }

}