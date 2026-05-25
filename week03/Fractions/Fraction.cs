using System;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = "";

        if (_top > 0 && _bottom > 0)
        {
            fractionString = $"{_top}/{_bottom}";

        } else if (_top > 0)
        {
            fractionString = $"{_top}/1";
        } 

        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = 0;

        if (_top > 0 && _bottom > 0)
        {
            decimalValue = _top / _bottom;

        } else if (_top > 0)
        {
            decimalValue = _top / 1;
        }

        return decimalValue;
    }
}
