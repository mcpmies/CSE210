using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction empty = new Fraction();
        Fraction whole = new Fraction(4);
        Fraction normal = new Fraction(2, 3);

        Console.WriteLine($"{empty.GetFractionString()} or {empty.GetDecimalValue()}");
        Console.WriteLine($"{whole.GetFractionString()} or {whole.GetDecimalValue()}");
        Console.WriteLine($"{normal.GetFractionString()} or {normal.GetDecimalValue()}");


        Random randomNumber = new Random();
        Fraction pt7 = new Fraction();
        int counter = 1;

        while(counter != 21)
        {
            int numberOne = randomNumber.Next(1, 100);
            int numberTwo = randomNumber.Next(1, 100);

            pt7.SetTop(numberOne);
            pt7.SetBottom(numberTwo);
            Console.WriteLine($"Fraction {counter} - string:{pt7.GetFractionString()} Number:{pt7.GetDecimalValue()}");

            counter += 1;
        }
    }
}