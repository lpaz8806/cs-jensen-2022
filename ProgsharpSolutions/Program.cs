partial class Program
{
    static void Main(string[] args)
    {
        RunUppgift5_2();
    }
    
    static void Prompt(string message)
    {
        if(!string.IsNullOrEmpty(message))
            Console.Write(message);
    }
    
    static string ReadString(string message)
    {
        Prompt(message);
        return Console.ReadLine() ?? string.Empty;
    }
    
    static int ReadInteger(string message)
    {
        return int.Parse(ReadString(message));
    }
}