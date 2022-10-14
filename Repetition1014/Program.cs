// See https://aka.ms/new-console-template for more information

IEnumerable<int> EvenNumbers(int count = int.MaxValue)
{
    var i = 0;
    while (--count >= 0)
    {
        yield return i;
        i += 2;
    }
}

void PrintRedLine(object x)
{
    _PrintColoredLine(x, ConsoleColor.Red);
}
void PrintBlueLine(object x)
{
    _PrintColoredLine(x, ConsoleColor.Blue);
}
void _PrintColoredLine(object x, ConsoleColor color)
{
    var initialColor = Console.ForegroundColor;
    Console.ForegroundColor = color;
    Console.WriteLine(x);
    Console.ForegroundColor = initialColor;
}


void Foreach<T>(IEnumerable<T> items, Action<object> print)
{
    foreach (var item in items)
        print(item);
}


Foreach(EvenNumbers(10), PrintRedLine);