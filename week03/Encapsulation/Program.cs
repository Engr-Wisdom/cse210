// Encapsulation is hiding and controlling access to information

using System;

class Program
{
    static void Main(string[] arg)
    {
        Person person1 = new Person();
        person1.SetFirstName("Wisdom");
        Console.WriteLine(person1.GetFirstName());
    }
}