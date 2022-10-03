using L05Classes;

class Program
{
    static void Main()
    {
        var parser = new RationalParser();
        var str = Console.ReadLine() ?? String.Empty;
        var r1 = parser.Parse(str);
        Console.WriteLine(r1);
    }
}
