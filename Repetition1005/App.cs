using System.Reflection;

namespace Repetition1005;

public class App
{
    private InputParser parser = new InputParser();
    public void Run()
    {
        while (true)
        {
            var input = ReadInput();
            
            if (IsQuitCommand(input))
                return;
            
            ProcessInput(input);
        }
    }

    private string ReadInput()
    {
        return Console.ReadLine() ?? string.Empty;
    }

    private bool IsQuitCommand(string input)
    {
        return input.Equals("quit", StringComparison.InvariantCultureIgnoreCase);
    }
    
    private void ProcessInput(string input)
    {
        try
        {
            // The parser is not implemented to return a ParserResult :)
            var pr = new ParserResult(default, default, default);
            var result = Dispatch(pr);
            Console.WriteLine(result.ToString());
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(ErrorMessages.DIVIDE_BY_ZERO);
        }
        catch (Exception e)
        {
            Console.WriteLine(ErrorMessages.SYNTAX_ERROR);
        }
    }

    private Rational Dispatch(ParserResult result)
    {
        switch (result.Operator)
        {
            case "": return result.Operand1;
            case "+": return result.Operand1 + result.Operand2;
            case "-": return result.Operand1 - result.Operand2;
            case ":": return result.Operand1 / result.Operand2;
            case "*": return result.Operand1 * result.Operand2;
            default: throw new Exception();
        }
    }
    
}