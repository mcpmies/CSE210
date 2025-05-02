using System;

class Program
{

    static double AddNumbers(double a, double b)
    {
        return a + b;
    }


    static void Main(string[] args)
    {
    //     List<int> myNumbers = new List<int>();
    //     myNumbers.Add(25);
    //     myNumbers.Add(32);

    //     foreach(int i in myNumbers)
    //     {
    //         Console.WriteLine(i);
    //     }

        double total = AddNumbers(123.98, 985.123456);
        Console.WriteLine(total);

        bool done = false;
        while(!done)
        {
            //...
            done = true;
        }

        do
        {

        }   while(!done);
    }
}