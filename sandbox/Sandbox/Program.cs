using System;

class Program
{
    static void Main(string[] args)
    {
        
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");

        myCircle.GetArea();
        Console.WriteLine($"{myCircle.GetArea()}");

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");
    }
}