
using System.Drawing;

public abstract class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getters and Setters
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}