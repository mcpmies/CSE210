using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Console.Write("Enter number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        if (number != 0)
        {
            numbers.Add(number);
        }

        while (number != 0)
        {
            Console.Write("Enter number: ");
            numberString = Console.ReadLine();
            number = int.Parse(numberString);
            numbers.Add(number);
        }

        int largestNumber = -99999;
        float sum = 0;

        foreach (int i in numbers)
        {
            sum += i;
            if (i > largestNumber)
            {
                largestNumber = i;
            }
        }

        numbers.RemoveAt(numbers.Count - 1);
        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}