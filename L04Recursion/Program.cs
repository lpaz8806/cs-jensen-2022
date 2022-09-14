namespace Recursion;

partial class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 13, 5, 69, 11 };
        var max = MaxInArray(numbers);
        Console.WriteLine(max);
    }
}