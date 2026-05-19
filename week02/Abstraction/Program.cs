using System;

public class Blind
{
    public double _width;
    public double _height;
    public string _color = "";
    public double GetArea()
    {
        return _width * _height;
    }
}

public class House
{
    public string _owner = "";
    public List<Blind> _blinds = new List<Blind>();
}

class Program
{
    static void Main(string[] arg)
    {
        // Create wisdomHome
        House wisdomHome = new House();
        wisdomHome._owner = "Wisdom's Family";

        // Create kitchen blind
        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "White";

        //create sitting room blind
        Blind sittingRoom = new Blind();
        sittingRoom._width = 72;
        sittingRoom._height = 52;
        sittingRoom._color = "White";

        // Add blind to list
        wisdomHome._blinds.Add(kitchen);
        wisdomHome._blinds.Add(sittingRoom);

        foreach (Blind b in wisdomHome._blinds)
        {
            double amount = b.GetArea();
            Console.WriteLine(amount);
        }
    }
}