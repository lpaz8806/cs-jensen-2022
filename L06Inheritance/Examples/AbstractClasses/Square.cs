namespace L06Inheritance.Examples.AbstractClasses;

public class Square : Figure
{
    private decimal side;
    public Square(decimal side)
    {
        this.side = side;
    }
    public override decimal Area()
    {
        return side * side;
    }

    public override decimal Perimeter()
    {
        return 4 * side;
    }
}