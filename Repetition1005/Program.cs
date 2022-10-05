// See https://aka.ms/new-console-template for more information

using Repetition1005;

var parser = new InputParser();

while (true)
{
    var input = Console.ReadLine() ?? string.Empty;
    if (input == string.Empty)
        return;
    try
    {
        var parsedStr = parser.Parse(input);
        Console.WriteLine(parsedStr);
    }
    catch (Exception e)
    {
        Console.WriteLine("Error dude!");
    }
}
/*
/// ParseOperand("37") => "37"
    /// ParseOperand("-2:3") => "-2"
    /// ParseOperand("-2/5") => "-2/5"
    /// ParseOperand("-2/5a") => "-2/5"
    /// ParseOperand("3.15abs") => "3.15"
    /// ParseOperand("a.15abs") => Exception
*/