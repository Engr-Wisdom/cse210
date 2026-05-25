using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction wholeNumber = new Fraction(1);
        Fraction topBottom = new Fraction(1, 3);

        Console.WriteLine(topBottom.GetFractionString());
        Console.WriteLine(topBottom.GetDecimalValue());
    }
}