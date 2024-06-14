using System;

class Program
{
    static void Main()
    {
        Circle myCircle = new Circle(5.0);
        Rectangle myRectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Area of Circle: {myCircle.GetArea()}");
        Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea()}");
    }
}
