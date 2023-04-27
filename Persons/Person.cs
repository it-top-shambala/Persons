namespace Persons;

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string GetFirstName()
    {
        return _firstName;
    }

    public string GetLastName() => _lastName;

    public string GetFullName() => $"{_lastName} {_firstName}";
}