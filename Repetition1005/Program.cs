// See https://aka.ms/new-console-template for more information

using Repetition1005;

class Program
{
    static void Main()
    {
        var parser = new InputParser();
        
        while (true)
        {
            var input = (Console.ReadLine() ?? string.Empty).Trim();
            
            if (input.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
                return;
            
            try
            {
                // var parsedStr = parser.Parse(input);
                ParserResult pr = default;
                var result = Dispatch(pr);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error dude!");
            }
        }
    }
    
    static Rational Dispatch(ParserResult pr)
    {
        switch (pr.Operator)
        {
            case "+": return pr.Operand1 + pr.Operand2;
            case "-": return pr.Operand1 - pr.Operand2;
            case ":": return pr.Operand1 / pr.Operand2;
            case "*": return pr.Operand1 * pr.Operand2;
            case "": return pr.Operand1;
            default: throw new Exception();
        }
    }
}
