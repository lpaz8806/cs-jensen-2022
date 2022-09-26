namespace L07Interfaces.Examples;

public static class Extensions
{
    public static bool IsPalindrome(this string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != s[^(i + 1)])
                return false;
        }

        return true;
    }

    public static IEnumerable<int> MapDouble(this IEnumerable<int> items)
    {
        foreach (var item in items)
            yield return 2 * item;
    }
    public static int HowMany<T>(this IEnumerable<T> items)
    {
        var count = 0;
        foreach (var item in items)
        {
            count++;
        }

        return count;
    }
    public static void PrintLines<T>(this IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}