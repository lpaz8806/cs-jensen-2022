namespace L06Inheritance.Examples;

public class Car
{
    protected int maxSpeed;
    protected int speed;
    public Car(int maxSpeed)
    {
        this.maxSpeed = maxSpeed;
    }

    public int Speed => speed;
    
    public virtual void Gas()
    {
        speed += 5;
    }
    public virtual void Break()
    {
        speed /= 2;
    }
}

public class ElectricCar : Car
{
    public ElectricCar(int maxSpeed)
        : base(maxSpeed)
    {
    }

    public override void Gas()
    {
        speed += 10;
    }

    public override void Break()
    {
        speed = 0;
    }
}

public sealed class Lådbil : Car
{
    public Lådbil() : base(5)
    {
    }

    public override void Gas()
    {
        speed++;
    }
    public override void Break()
    {
        speed = 0;
    }
}
