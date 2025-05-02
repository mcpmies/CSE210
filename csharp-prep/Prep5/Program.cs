using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(username, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared = number * 2;
        return squared;
    }

    static void DisplayResult(string username, int squared)
    {
        Console.WriteLine($"{username}, the square of your number is {squared}");
    }
}