using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,100);

        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        int guess = int.Parse(guessString);

        while(guess != randomNumber)
        {
            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guessString = Console.ReadLine();
                guess = int.Parse(guessString);
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guessString = Console.ReadLine();
                guess = int.Parse(guessString);
            }
        }

        Console.WriteLine("You guessed it!");
    }
}