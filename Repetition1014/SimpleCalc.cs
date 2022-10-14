namespace Repetition1014;

public class SimpleCalc
{
    private Dictionary<string, int> variables = new();

    public void Run()
    {
        while (true)
        {
            var input = (Console.ReadLine() ?? String.Empty).Trim();
            if (string.IsNullOrEmpty(input))
                return;
                
            var parts = input.Split(' ', StringSplitOptions.TrimEntries);
            Dispatch(parts);
        }
    }

    void Dispatch(string[] args)
    {
        if (args[0] == "=")
        {
            variables.Add(args[1], int.Parse(args[2]));
            return;
        }

        if (variables.TryGetValue(args[0], out int x))
        {
            Console.WriteLine(x);
        }
        else
        {
            Console.WriteLine($"Undefined var '{args[0]}'");
        }
            
        
    }
}
