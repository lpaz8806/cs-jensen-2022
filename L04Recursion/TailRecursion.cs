namespace Recursion;

partial class Program
{
    static int AddRecursive(int x, int y)
    {
        if (x == 0) return y;
        if (y == 0) return x;

        return AddRecursive(x + 1, y - 1);
    }
    static int AddIterative(int x, int y)
    {
        for (int i = 1; i < y; i++)
            x++;
        return x;
    }
}