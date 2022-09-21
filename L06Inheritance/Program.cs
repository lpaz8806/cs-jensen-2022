// See https://aka.ms/new-console-template for more information


/*
Inheritance +
virtual och override +
Abstrakta klasser
Polymorfism
Casting
Object superclass
Operators is and as
Sealed
 */

using L06Inheritance.Examples;
using L06Inheritance.Examples.AbstractClasses;

class Program
{
    static void Main()
    {
        var sqr = new Square(5);
        
        

        // Console.WriteLine(sqr.Area());
        return;
        
        Figure[] figures =
        {
          new Square(5),
          new Circle(1m),
          new Square(10)
        };

        var total = Figure.SumPerimeter(figures);
        Console.WriteLine(total);
    }

    
    
    
}

