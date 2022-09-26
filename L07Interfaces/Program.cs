using System.Text;
using L07Interfaces.Examples;

namespace L07Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine() ?? String.Empty;
        Console.WriteLine("True");

    }

    static int DivRem(int x, int y, out int rem)
    {
        rem = x % y;
        return x / y;
    }
    
    static bool IsNumber(string str, out int x)
    {
        if (str.Length == 4)
        {
            x = 5;
        }

        x = default;
        return false;
    }
    
}