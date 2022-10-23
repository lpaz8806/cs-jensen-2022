using System.Threading.Channels;

namespace L10DesignPrinciples;

static class App
{
    public static void Run()
    {
        IQuackable[] ducks =
        {
            new KalleAnka(),
            new KalleAnka(),
            new GummiAnka()
        };

        foreach (var quackable in ducks)
        {
            quackable.Quack();
        }
        
        
    }

    static void ViolateLiskov()
    {
        Duck[] ducks =
        {
            new KalleAnka(),
            new KalleAnka(),
            new RubberDuck()
        };

        foreach (var duck in ducks)
        {
            if(duck is RubberDuck)
                continue;
            duck.Fly();
        }
    }
}

public abstract class Duck 
    : IFlyable, IWalkable, IQuackable
{
    public abstract void Fly();
    public abstract void Walk();
    public abstract void Swim();
    public abstract void Quack();
}

public class KalleAnka : Duck
{
    public override void Fly()
    {
        Console.WriteLine("Flying high...");
    }

    public override void Walk()
    {
        Console.WriteLine("Walking like all ducks");
    }

    public override void Swim()
    {
        Console.WriteLine("Swimming like Phelps");
    }

    public override void Quack()
    {
        Console.WriteLine("Quack Quack");
    }
}

// A RubberDuck is NOT a Duck
public class RubberDuck : Duck
{
    public override void Fly()
    {
        throw new NotSupportedException();
    }

    public override void Walk()
    {
        throw new NotSupportedException();
    }

    public override void Swim()
    {
        Console.WriteLine("RD floating, consider it swimming");
    }

    public override void Quack()
    {
        Console.WriteLine("Wisssh wissssh");
    }
}

public class GummiAnka : IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Wisssh wissssh");
    }
}

public interface IFlyable
{
    public void Fly();
}

public interface IWalkable
{
    public void Walk();
}

public interface IQuackable
{
    public void Quack();
}