﻿class Program
{

    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Crocker", 23);
        Console.WriteLine(myPoliceMan.GetPersonInformation());
    }
}
