using System.Threading.Channels;
using L07Interfaces.Examples;
using L07Interfaces.Exercises;

namespace L07Interfaces;

class Program
{
    static void Main(string[] args)
    {
    }

    static void Print<T>(IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}