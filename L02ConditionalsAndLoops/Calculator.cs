namespace ConditionalsAndLoops;

partial class Program
{
    /// <summary>
    /// This method is to be called in Main for playing around
    /// </summary>
    /// <returns>true when the user wants to exit/quit, false otherwise</returns>
    static bool RunCalculator()
    {
        var x = ReadDouble("Type a number: ");
        var y = ReadDouble("Type another number: ");
        var op = ReadOperator("Type an operation: ");

        if (op == char.MinValue)
            return true;
        
        var result = Calculate(x, y, op);
        Console.WriteLine(result);
        return false;
    }
    
    static double ReadDouble(string prompt)
    {
        if (!string.IsNullOrEmpty(prompt))
            Console.Write(prompt);

        var input = Console.ReadLine() ?? "0";
        return double.Parse(input);
    }

    static char ReadOperator(string prompt)
    {
        if (!string.IsNullOrEmpty(prompt))
            Console.Write(prompt);

        var input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
            return char.MinValue;

        return input[0];
    }
    
    /// <summary>
    /// Computes one of the 4 basic operations based on the specified operator <see cref="op"/>
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="op">One of '+', '-', '*', '/' representing the operation to be performed</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">When the operation is not supported</exception>
    static double Calculate(double x, double y, char op)
    {
        switch (op)
        {
            case '+': return x + y;
            case '-': return x - y;
            case '*': return x * y;
            case '/': return x / y;

            // DO NOT PAY ATTENTION TO THIS PART. WE WILL STUDY THE EXCEPTIONS LATER IN THE COURSE.
            // For fun, try to use this method with '@' and see how beautifully it explodes
            default:
                throw new NotSupportedException($"Operation {op} is not supported");
        }
    }
}