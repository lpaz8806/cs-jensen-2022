namespace L07Interfaces.Exercises;

public static class Strings
{
    /// <summary>
    /// Produces the elements in the specified sequence in upper case
    /// </summary>
    public static IEnumerable<string> ToUpper(IEnumerable<string> items)
    {
        foreach (var item in items)
            yield return item.ToUpper();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Produces the elements in the specified sequence (items)
    /// which length is at least minLength
    /// </summary>
    public static IEnumerable<string> FilterByMinLength(IEnumerable<string> items, int minLength)
    {
        foreach (var str in items)
            if (str.Length >= minLength)
                yield return str;
    }
    
    //------------------------------------------------------------//
    
    
}