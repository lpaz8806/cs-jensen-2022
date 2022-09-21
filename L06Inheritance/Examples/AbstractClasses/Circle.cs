namespace L06Inheritance.Examples.AbstractClasses;

public class Circle : Figure
{
    private decimal radius;

    public Circle(decimal radius)
    {
        this.radius = radius;
    }
    
    public override decimal Area()
    {
        return (decimal)Math.PI * radius * radius;
    }

    public override decimal Perimeter()
    {
        return 2 * (decimal)Math.PI * radius;
    }

    public override void Print()
    {
        Console.WriteLine("Im a Circle");
    }
}