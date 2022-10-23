// A Dictionary is a map key => value

using System.Text;

void Ages()
{
    var agesMap = new Dictionary<string, int>();
    agesMap.Add("Luis", 34);
    agesMap.Add("Foo", 25);
    Console.WriteLine($"Luis is {agesMap["Luis"]} years old");
}

void HoldSymbols()
{
    // Holding "variables"
    var symbolTable = new Dictionary<string, string>();
    // x = 2/5
    symbolTable.Add("x", "2/5");
    // y = 1/2 + x
    var result = "1/2 + " + symbolTable["x"];
    symbolTable["y"] = result;


    var supportedFunctions = new Dictionary<string, Func<double, double>>();
    supportedFunctions["sqrt"] = Math.Sqrt;
    supportedFunctions["log"] = Math.Log10;

    // log(100)
    Console.WriteLine(supportedFunctions["log"](100));
}

void UsingDelegates()
{
    // represents a function that takes a double and returns a double
    Func<double, double> sqrt = Math.Sqrt; // Method Group

    // anonymous function / lambda expression
    Func<double, double, double> hypotenuse =
        (x, y) => Math.Sqrt(x * x + y * y);
    // Console.WriteLine(hypotenuse(3, 4));

    Action sayHi = () => Console.WriteLine("Hello");
    Action<string> sayHiWithName = name => Console.WriteLine($"Hello, {name}");
    sayHiWithName("Elia");

    T Reduce<T>(Func<T,T,T> reduce, params T[] items)
    {
        T result = items[0];
        for (int i = 1; i < items.Length; i++)
            result = reduce(result, items[i]);
        return result;
    }

    var sum = Reduce(
        (x, y) => x * y, 
        1, 2, 3, 4, 5, 6, 7, 8, 9);
    Console.WriteLine(sum);
}

void UsingRefKeyword()
{
    void Swap<T>(ref T x, ref T y) // take x as an alias for the variable passed
    {
        Console.WriteLine($"Args: x = {x}, y = {y}");
        (x, y) = (y, x);
        Console.WriteLine($"After Swap: x = {x}, y = {y}");
    }

    var foo = 10;
    var goo = 20;
    Console.WriteLine($"Before calling Swap: foo = {foo}, goo = {goo}");
    Swap(ref foo, ref goo);
    Console.WriteLine($"After Swap returned: foo = {foo}, goo = {goo}");
}

// Avoid assignment as much as possible
// Side-effects
// Pure Function

int Sum(int x, int y)
{
    var result = x + y;
    return result;
}

// immutable = Can't be changed

var r = new Rat() {Num = 1, Den = 2};
Console.WriteLine($"r = {r}");
var w = r.WithDen(10);
Console.WriteLine($"w = {w}");
Console.WriteLine($"r = {r}");

class Rat
{
    public int Num { get; init; }
    public int Den { get; init; }
    
    public Rat WithDen(int den) => new Rat() {Num = Num, Den = den};

    public override string ToString() => $"{Num} / {Den}";
}
