namespace L06Inheritance.Examples.AbstractClasses;

public class Rectangle : Figure
{
    public decimal Length { get; set; }
    public decimal Width { get; set; }

    public Rectangle(decimal length, decimal width)
    {
        this.Length = length;
        this.Width = width;
    }
    
    public override decimal Area()
    {
        return Length * Width;
    }

    public override decimal Perimeter()
    {
        return 2 * (Length + Width);
    }
}