using System;

public class Fraction
{
    private int _top;
    private int _bottom;

// Fraction Contructors, these set an uniform value to the variables of the class
    public Fraction()
    {
        _top = 1; 
        _bottom = 1; 
    }
    public Fraction(int top)
    {
        _top = top;
    }
    public Fraction(int top, int bottom)
    {
        _top = top; 
        _bottom = bottom; 
    }

// Getter and Setter implementation
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;   
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
// Methods for the Fraction class
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom; 
    }




}
