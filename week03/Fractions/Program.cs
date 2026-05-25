using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction wholeNumber = new Fraction(1);
        Fraction topBottom = new Fraction(1, 3);
        // fraction.SetTop(4);
        // fraction.SetBottom(8);
        // Console.WriteLine(fraction.GetTop());
        // Console.WriteLine(fraction.GetBottom());

        Console.WriteLine(topBottom.GetFractionString());
        Console.WriteLine(topBottom.GetDecimalValue());
    }
}