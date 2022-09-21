namespace L06Inheritance.Examples.AbstractClasses;

public abstract class Figure
{
    public abstract decimal Area();
    public abstract decimal Perimeter();

    public static decimal SumAreas(Figure[] figures)
    {
        var sum = 0m;
        
        for (var i = 0; i < figures.Length; i++)
            sum += figures[i].Area();
        
        return sum;
    }
    
    public static decimal SumPerimeter(Figure[] figures)
    {
        var sum = 0m;
        
        for (var i = 0; i < figures.Length; i++)
            sum += figures[i].Perimeter();
        
        return sum;
    }
}
