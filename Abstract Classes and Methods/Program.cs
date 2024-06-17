abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class Program()
{
    static void Main(string[] args)
    {
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(10);
        Rectangle rectangle = new Rectangle(4, 3);

        // Display areas using GetArea()
        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
    }
}