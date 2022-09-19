namespace Recursion;

partial class Program
{
    static void Main(string[] args)
    {
        bool[,] map =
        {
            { true, false, false, true },
            { true, true, false, false },
            { true, false, false, true },
            { true, false, false, true }
        };

        var maxArea = ComputeAreaOfLargestIsland(map);
        Console.WriteLine(maxArea);
    }
    
}