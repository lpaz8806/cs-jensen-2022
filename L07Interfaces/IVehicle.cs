namespace L07Interfaces;

public interface IRandomGenerator
{
    int Generate();
}

public interface IDigitGenerator
{
    int Generate();
}

public class MyCoolGenerator : 
    IRandomGenerator, IDigitGenerator
{
    private static Random r = new Random();
    public int Generate()
    {
        return r.Next(0, int.MaxValue);
    }
    
    int IDigitGenerator.Generate()
    {
        var n = Generate();
        return 1 + n % 9;
    }
}