namespace L08FunctionProgramming;

public static class Extensions
{
    public static T FindFirstOrDefault<T>(this IEnumerable<T> items, Predicate<T> match)
    {
        foreach (var item in items)
            if (match(item))
            {
                return item;
            }

        return default;
    }
    
    public static IEnumerable<T> Map<T>(
        this IEnumerable<T> items,
        Func<T, T> map)
    {
        foreach (var item in items)
            yield return map(item);
        
    }

    public static Func<TIn, TOut> CompoundWith<TIn,TOut, T>(
        this Func<T, TOut> f,
        Func<TIn, T> g)
    {
        return x => f(g(x));
    }

}