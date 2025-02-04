

public class PictureBook : Book
{
    private string _illustrator = "";

    public string GetIllustrator()
    {
        return _illustrator;
    }
    public void SetIllustrator(string Illustrator)
    {
        _illustrator = Illustrator;
    }
}