

using System.Diagnostics.Contracts;

public class WritingAssigment : Assignment
{
    private string _title = "";

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"\n{GetSummary()}\n{_title}\n";
    }

    
}