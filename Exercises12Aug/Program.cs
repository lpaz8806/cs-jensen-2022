namespace Exercises12Aug;

partial class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine() ?? "";
        var output = RemoveDuplicates(input);
        Console.WriteLine(output);
    }
}

