using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int largest = 0;
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number:  ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        foreach (int x in numbers)
        {
            sum += x;
            if (x > largest)
            {
                largest = x;
            }
        }
        float average = sum / numbers.Count();

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");

    }
}