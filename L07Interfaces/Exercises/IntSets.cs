using NotImplementedException = System.NotImplementedException;

namespace L07Interfaces.Exercises;

public static class IntSets
{
    /// <summary>
    /// Produces the first n terms of the Fibonacci sequence
    /// </summary>
    public static IEnumerable<int> Fibonacci(int n)
    {
        for (int i = 0; i < n; i++)
            yield return Fib(i);

        // Local method. A method inside another method
        int Fib(int k) => k < 2 ? k : Fib(k - 1) + Fib(k - 2);
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Produces the first n squares starting at 0
    /// </summary>
    public static IEnumerable<int> Squares(int n)
    {
        for (int i = 0; i < n; i++)
            yield return i * i;

    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Produces the first n elements of the specified sequence
    /// (items)
    /// </summary>
    /// <example>
    /// Take({1,2,3,4,5,6,7,8,9,...}, 5) => {1,2,3,4,5}
    /// Take({1,2,3}, 5) => {1,2,3}
    /// </example>
    public static IEnumerable<T> Take<T>(IEnumerable<T> items, int n)
    {
        foreach (var item in items)
        {
            if(--n < 0)
                yield break;
            
            yield return item;
        }
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Produces the sequence of elements starting by the (n+1)th
    /// in the specified sequence
    /// </summary>
    /// <example>
    /// Skip({1,2,3,4,5,6,7,8,9,...}, 3) => {4,5,6,7,8,9,...}
    /// Skip({1,2,3}, 5) => { }
    /// </example>
    public static IEnumerable<T> Skip<T>(IEnumerable<T> items, int n)
    {
        foreach (var item in items)
        {
            if (--n >= 0)
                continue;
            
            yield return item;
        }
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Produces the first n terms of the Wirth sequence
    /// </summary>
    public static IEnumerable<int> Wirth(int n)
    {
        return Take(Wirth(), n);
    }
    public static IEnumerable<int> Wirth()
    {
        return WirthRecursive(1);
    }
    private static IEnumerable<int> WirthRecursive(int k)
    {
        yield return k;
        var branch2 = WirthRecursive(2 * k + 1).GetEnumerator();
        var branch3 = WirthRecursive(3 * k + 1).GetEnumerator();

        while (branch2.MoveNext() && branch3.MoveNext())
        {
            yield return branch2.Current;
            yield return branch3.Current;
        }
    }
    //------------------------------------------------------------//
    
}