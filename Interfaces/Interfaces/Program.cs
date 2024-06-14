using System;

class Program
{
    static void Main()
    {
        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();

        myCar.Move();
        myBicycle.Move();
    }
}
