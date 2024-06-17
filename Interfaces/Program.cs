using System;

// Interface for movable objects
interface IMovable
{
    void Move();
}

// Car class implementing IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle class implementing IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        // Create instances of Car and Bicycle
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        // Call Move() on each instance (polymorphism in action)
        car.Move();
        bicycle.Move();
    }
}