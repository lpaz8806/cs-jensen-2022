using System.Threading.Channels;
using Repetition1014;

void Dict()
{
    var functions = new Dictionary<string, Func<int, int>>
    {
        { "square", x => x*x},
        { "nth-even", x => 2*x}
    };

    functions.Add("nth-odd", x => 2 * x + 1);


    Console.Write("Gimmie an int: ");
    var arg = int.Parse(Console.ReadLine() ?? String.Empty);

    Console.Write("Gimmie a func: ");
    var funcName = Console.ReadLine() ?? String.Empty;

    if(functions.ContainsKey(funcName))
        Console.WriteLine(functions[funcName](arg));
    else
        Console.WriteLine("No clue what you're talking about");

}

void Fib()
{
    // memoization
    ulong Fibonacci(int n)
    {
        var dict = new Dictionary<int, ulong> { {0, 0}, {1, 1} };
        return FibonacciMemoized(n, dict);
    
    
        ulong FibonacciMemoized(int n, Dictionary<int, ulong> memo)
        {
            if (memo.ContainsKey(n))
                return memo[n];

            var fibOfN = FibonacciMemoized(n - 1, memo) + FibonacciMemoized(n - 2, memo);
            memo.Add(n, fibOfN);
            return fibOfN;
        }
    }
    Console.WriteLine(Fibonacci(50));
}

void SimpleCalc()
{
    var calc = new SimpleCalc();
    calc.Run();
}

void NullCoalesce()
{
    string? str = null;

    var ifNullTakeOtherValue = str ?? "This sh** is null";
    var result = str == null ? "This sh** is null" : str;

}


void UsingLambda()
{
    int TwoXPlus1NoArrow(int x)
    {
        return 2 * x + 1;
    }
    int TwoXPlus1(int x) => 2 * x + 1;


// lambda expression
    Func<int, int> square = x => x*x;
}


void UsingRange()
{
    var oneToTen = new MyRange(5, 10);
    Console.WriteLine(string.Join(", ", oneToTen.EvenNumbers()));
}


void UsingRefKeyword()
{
    int x = 10;
    int y = 20;
    
    Console.WriteLine($"x = {x}, y = {y}");
    Swap(ref x, ref y);
    Console.WriteLine($"x = {x}, y = {y}");


    void Swap<T>(ref T t1, ref T t2)
    {
        var temp = t1;
        t1 = t2;
        t2 = temp;
    }
}


void UsingOutKeyword()
{
    int x = 25;
    int y = 3;

    var quot = DivRem(x, y, out var reminder);
    Console.WriteLine(quot);
    Console.WriteLine(reminder);
    
    int DivRem(int x, int y, out int rem)
    {
        rem = x % y;
        return x / y;
    }
}

void Functional()
{
    // pure functional way
    // assignment is just allowed to create data, not to mutate data
    // in a more relax functional approach, the assignment is only allowed
    // in very specific places, normally hidden (encapsulated)
    
    var enumerable = new MyRange(5, 10)
        .Select(x => x * x)
        .Where(x => x < 50);
    Console.WriteLine(string.Join(", ", enumerable));


    // side-effects
    var originalNumbers = new List<int>(){5,6,7,8,9,10};

    var numbers = originalNumbers;
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] *= numbers[i];
    }

    int j = 0;
    while (j < numbers.Count)
    {
        if (numbers[j] >= 50)
            numbers.RemoveAt(j);
        else
            j++;
    }
    // by mutating numbers we also mutate originalNumbers
}

void UsingParams()
{
    // params is sugar syntax for multiple parameters of the same type
    // must be the last argument in a method
    int[] intNumbers = {1, 2, 3};
    
    Console.WriteLine(SumArr(intNumbers));
    
    Console.WriteLine(Sum(1, 2, 3));
    Console.WriteLine(Sum(intNumbers));
    
    
    int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }
    int SumArr(int[] numbers)
    {
        return numbers.Sum();
    }
}

void Throw()
{
    Console.WriteLine(Div(3, 0));

    int Div(int x, int y)
    {
        return y != 0
            ? x / y
            : throw new DivideByZeroException();
    }
}
