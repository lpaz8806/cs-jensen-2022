namespace Handledning;

class Program
{
    static void Main(string[] args)
    {
    }
    
    /// <summary>
    /// Skapa ett program som innehåller en array med minst 5 årtal,
    /// minst ett av årtalen ska finnas med två gånger. Användaren
    /// ska få skriva in ett årtal när programmet körs. Programmet
    /// ska skriva ut alla index som detta årtal finns på i arrayen.
    /// Om årtalet inte fanns på någon plats så ska programmet
    /// skriva "Årtalet kunde inte hittas".
    /// </summary>
    static void RunProblem()
    {
        int[] years = GenerateYears();
        // WriteHints(years);
        
        var year = ReadUserInput();

        if (ArrayContains(years, year))
            WriteIndicesOfElementInArray(years, year);
        else
            Console.WriteLine("Årtalet kunde inte hittas");
    }
    
    /// <summary>
    /// returns an array med minst 5 årtal,
    /// minst ett av årtalen ska finnas med två gånger
    /// </summary>
    /// <returns></returns>
    static int[] GenerateYears()
    {
        Random rnd = new Random();
        int[] years = new int[10];

        for (int i = 0; i < years.Length; i++)
            years[i] = rnd.Next(1900, 2022);

        var randomIndex = rnd.Next(1, years.Length - 1);
        years[randomIndex] = years[0];
        
        return years;
    }
    
    static int ReadUserInput()
    {
        Console.Write("Guess a year: ");
        var input = Console.ReadLine() ?? string.Empty;
        return int.Parse(input);
    }
    
    static bool ArrayContains(int[] years, int year)
    {
        for (int i = 0; i < years.Length; i++)
            if (years[i] == year)
                return true;
        
        return false;
    }
    
    static void WriteIndicesOfElementInArray(int[] years, int year)
    {
        for (int index = 0; index < years.Length; index++)
            if (years[index] == year)
                Console.WriteLine(index);
    }

    static void WriteHints(int[] years)
    {
        var min = years.Min();
        var max = years.Max();

        Console.WriteLine($"Årtalen är mellan {min} och {max}");
    }
    
    
    /// <summary>Creates a copy of the specified array</summary>
    /// <returns>A new array containing the same elements as the source</returns>
    public static T[] ArrayClone<T>(T[] source)
    {
        var clone = new T[source.Length];
        
        for (int i = 0; i < source.Length; i++)
            clone[i] = source[i];

        return clone;
    }
}