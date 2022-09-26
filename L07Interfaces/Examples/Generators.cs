namespace L07Interfaces.Examples;

public static class Generators
{
    public static IEnumerable<int> EvenNumbers()
    {
        var current = 0;
        while (true)
        {
            yield return current;
            current += 2;
        }
    }
    
    public static IEnumerable<int> EvenNumbers(int max)
    {
        foreach (var number in EvenNumbers())
        {
            if(number > max)
                yield break;
            
            yield return number;
        }
    }
}