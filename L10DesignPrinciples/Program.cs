

#region C# Features

void SwitchStatement()
{
    int code;
    switch (Console.ReadLine())
    {
        case "1":
            code = 127;
            break;
        case "2":
            code = 0;
            break;
        default:
            code = -1;
            break;
    }
}

void SwitchExpression()
{
    var kod = Console.ReadLine() switch
    {
        "1" => 127,
        "2" => 0,
        _ => -1
    };

    Console.WriteLine(kod);
}

void SwitchExpression2()
{
    var x = int.Parse(Console.ReadLine());
    var sign = x switch
    {
        > 0 => 1,
        < 0 => -1,
        _ => 0
    };

    Console.WriteLine(sign);
}

void LogicalPatterns()
{
    var c = '+';
    if (c is '+' or '-')
    {
    
    }
    // instead of
    // c == '+' || c == '-'
}

void NullCoalesceAssignment()
{
    List<int> numbers = null;
    // (numbers != null ? numbers : numbers = new List<int>()).Add(5);
    (numbers ??= new List<int>()).Add(5);
}

#region Tuples Examples

void RunTuplesExample()
{
    var nameAge = (Name : "Luis", Age: 34, FavoriteBand:"Megadeth");

    Console.WriteLine(nameAge.Age);


    var parsingResult = TryParse("123");

    if(parsingResult.Success)
        Console.WriteLine(parsingResult.Value);

    (bool Success, int Value) TryParse(string str)
    {
        var success =int.TryParse(str, out int x);
        return (success, x);
    }


    var myDict = CreateDictionary(
        ("Luis", 34),
        ("Foo", 200),
        ("Gretta", 9)
    );
}



IDictionary<TKey, TValue> CreateDictionary<TKey, TValue>(
    params (TKey, TValue)[] args)
{
    var dict = new Dictionary<TKey, TValue>();
    foreach (var item in args)
    {
        dict.Add(item.Item1, item.Item2);
    }

    return dict;
}

void Swap<T>(ref T x, ref T y)
{
    (x, y) = (y, x);
}

#endregion


#endregion

#region Design Principles

// S.O.L.I.D principles
// Robert C. Martin (Clean Code, Clean Architecture)

// Single Responsibility Principle (S)
// One module should have ONLY ONE reason to change

// Open closed principles (O)
// A module should be open for extension and closed for modification
// A module should be extensible by writing new code, not by modifying
// existing code

// Liskov substitution principle (L)
// Any object must be replaceable by a derived class without
// the need to know it

// Interface segregation principle (I)
// 

// Dependency inversion principle (D)
// High level modules should not depend on low level
// details. Both should depend on abstractions

#endregion


