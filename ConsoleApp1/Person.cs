using System.Security.Cryptography;

class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person()
    {
        _firstName = "";
        _lastName = "";
        _age = 0;
    }

    public Person(string _firstName, string _lastName, int _age)
    {
        _firstName = _firstName;
        _lastName = _lastName;
        _age = _age;
    }

    public string GetPersonInformation()
    {
        return $"{_firstName} {_lastName} age: {_age}";
    }
}