using System.Text.RegularExpressions;
using L08FunctionProgramming.Events;

namespace L08FunctionProgramming;

class Program
{
    static void Main()
    {
        var lisa = new PrettyGirl();
        var chad = new SuperHero();

        chad.Protect(lisa);
    }

    static void DoYourThingYo(object sender, EventArgs e)
    {
        Console.WriteLine("I'm a method");
    }
    
    static void ArraySort<T>(T[] items, Jamfoerelse<T> compare)
    {
        for (int i = 0; i < items.Length - 1; i++)
        for (int j = i + 1; j < items.Length; j++)
        {
            if (compare(items[i], items[j]) > 0)
            {
                var tmp = items[i];
                items[i] = items[j];
                items[j] = tmp;
            }
        }
    }

    
}
