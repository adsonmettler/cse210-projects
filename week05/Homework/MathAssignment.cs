

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";


    public string GetTextBookSection()
    {
        return _textbookSection;
    }
    public void SetTextBookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public string GetProblem()
    {
        return _problems;
    }
    public void SetProblem(string problems)
    {
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"\n{GetSummary()}\n{_textbookSection} {_problems}";
    }


}