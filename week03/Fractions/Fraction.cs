// Author: Adson Mettler do Nascimento


public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator =1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    
    // Setter
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}