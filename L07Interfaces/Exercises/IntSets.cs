namespace L07Interfaces.Exercises;

public static class IntSets
{
    /// <summary>
    /// Produces the first n terms of the Fibonacci sequence
    /// </summary>
    public static IEnumerable<int> Fibonacci(int n)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Produces the first n squares starting at 0
    /// </summary>
    public static IEnumerable<int> Squares(int n)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Produces the first n terms of the Wirth sequence
    /// </summary>
    public static IEnumerable<int> Wirth(int n)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
}