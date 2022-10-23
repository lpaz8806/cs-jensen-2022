using System.Threading.Channels;

namespace L10DesignPrinciples;

public class VendingMachine
{
    private static List<string> _options = new();
    public static List<string> Options => _options;

    public static void MainThing()
    {
        Options.Add("CocaCola");
        Options.Add("Kex");
        Options.Add("Pringles");
        Options.Add("Lakrits");
        
        Run();
    }

    static void Run()
    {
        while (true)
        {
            var option = Console.ReadLine();
            if (option == string.Empty)
                return;
            
            DispatchOption(option);
        }
    }
    
    
    static void DispatchOption(string option)
    {
        var i = int.Parse(option) - 1;

        var product = i >= 0 && i < Options.Count
            ? Options[i] 
            : throw new Exception();
        
        Console.WriteLine(product);
    }
}