using System.Text.RegularExpressions;
using System.Threading.Channels;
using L08FunctionProgramming.Events;
using L08FunctionProgramming.Exercises;

namespace L08FunctionProgramming;

class Program
{
    static void Main()
    {
        int[] items = { 1, 2, 3, 4, 5 };
        string[] strs = { "Hello", "world", "happy", "sad" };
        var str = strs.Reduce(
            string.Empty,
            CreateSeparator(5, '_')
        );
        Console.WriteLine(str);
    }

    static Func<string, string, string> CreateSeparator(int spaces, char c = ' ')
    {
        var separator = new string(c, spaces);
        return (s,w) => $"{s}{separator}{w}".Trim(c);
    }

    static string SpaceSeparate(string s, string w)
    {
        return $"{s} {w}".Trim();
    }
    static int Sum(int x, int y) => x + y;
}
