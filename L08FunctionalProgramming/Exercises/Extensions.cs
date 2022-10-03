namespace L08FunctionProgramming.Exercises;

public static class Extensions
{
    // Implement an extension method Reduce
    // on an IEnumerable<T> such that
    // given a starting element T0 and
    // a reduction function f:T,T->T
    // reduces the given collection
    // to a single element of type T
    public static T Reduce<T>(
        this IEnumerable<T> items,
        T start,
        Func<T,T,T> f)
    {
        var result = start;
        foreach (var item in items)
            result = f(result, item);
        return result;
    }
    
    // Implement an extension method Filter
    // on an IEnumerable<T> c such that
    // given a Predicate<T> p it produces
    // the elements in c matching p
    static void foo()
    {
    }
}