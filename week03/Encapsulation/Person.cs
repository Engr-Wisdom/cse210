using System;

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
}