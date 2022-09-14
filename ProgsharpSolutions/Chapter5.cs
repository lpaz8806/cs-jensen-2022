partial class Program
{
    //-------------Uppgift 5.1-----------------------------------------------------//
    
    /// <summary>
    /// Skapa ett program som innehåller en array som ska innehålla namnen på
    /// tre svenska städer. Skriv in två av namnen i programmets kod men låt
    /// användaren få skriva in namnet på den tredje staden. Skriv
    /// avslutningsvis ut alla stadsnamnen på samma rad.
    /// </summary>
    static void RunUppgift5_1()
    {
        string[] cities = new string[3];
        cities[0] = "Stockholm";
        cities[1] = "Göteborg";
        cities[2] = ReadString("Skriv in tredje städ i Sverige: ");

        Console.WriteLine("The big three in Sweden:");
        Console.WriteLine(string.Join(", ", cities));
    }
    
    //-------------Uppgift 5.2-----------------------------------------------------//
    
    /// <summary>
    /// Skapa ett program där användaren ska få skriva in en lista över alla
    /// sporter som hen har testat. Fråga först användaren hur många sporter
    /// hen vill skriva in. Därefter ska sporterna skrivas in, en efter en,
    /// på var sin rad. Slutligen ska programmet skriva ut namnen på alla
    /// sporterna som användaren skrev in.
    /// </summary>
    static void RunUppgift5_2()
    {
        var sportsCount = ReadInteger("Hur många sporter du vill skriva in? ");
        var sports = ReadSports(sportsCount, "Skriv in sport: ");

        Console.WriteLine("Du skrev:");
        PrintSports(sports);
    }

    static string[] ReadSports(int count, string message)
    {
        var items = new string[count];

        for (var i = 0; i < items.Length; i++)
            items[i] = ReadString(message);

        return items;
    }
    static void PrintSports(string[] sports)
    {
        for (var i = 0; i < sports.Length; i++)
            Console.WriteLine(sports[i]);
    }
    
    //-------------Uppgift 5.3-----------------------------------------------------//
    
    static void RunUppgift5_3()
    {
        var numbers = GenerateRandomIntArray(10, int.MinValue, int.MaxValue);
        var max = Max(numbers);
        Console.WriteLine($"Max nummer hittade: {max}");
    }

    static int Max(int[] numbers)
    {
        var max = numbers[0];
        
        for (var i = 1; i < numbers.Length; i++)
            if (numbers[i] > max)
                max = numbers[i];
        
        return max;
    }
    static int[] GenerateRandomIntArray(int count, int min, int max)
    {
        var integers = new int[count];
        var randomGenerator = new Random();
        
        for (var i = 0; i < count; i++)
            integers[i] = randomGenerator.Next(min, max);
        
        return integers;
    }
    
    //-------------Uppgift 5.4-----------------------------------------------------//

    /// <summary>
    /// Skapa ett program som innehåller en array med minst 5 årtal, minst ett av
    /// årtalen ska finnas med två gånger. Användaren ska få skriva in ett årtal
    /// när programmet körs. Programmet ska skriva ut alla index som detta årtal
    /// finns på i arrayen. Om årtalet inte fanns på någon plats så ska programmet
    /// skriva "Årtalet kunde inte hittas".
    ///
    /// https://progsharp.se/kapitel/5/#uppgift-54
    /// </summary>
    static void RunUppgift5_4()
    {
        var years = GenerateYearsArray(5);

        PrintHints(years);
        var year = ReadInteger("Skriva in ett årtal: ");

        if (YearExists(years, year))
        {
            PrintIndicesOfYearInArray(years, year);
        }
        else
        {
            Console.WriteLine("Årtalet kunde inte hittas");
        }
    }

    static int[] GenerateYearsArray(int count)
    {
        var years = GenerateRandomIntArray(count, 1980, 2022);
        years[years.Length - 1] = years[0]; // Guarantees duplicated element. 
        return years;
    }
    static bool YearExists(int[] years, int year)
    {
        for (int i = 0; i < years.Length; i++)
            if (years[i] == year)
                return true;

        return false;
    }
    static void PrintHints(int[] years)
    {
        var min = Min(years);
        var max = Max(years); // implemented in ex. 5.3
        Console.WriteLine($"Hint: Årtalet ligger mellan {min} och {max}");
    }
    
    static int Min(int[] numbers)
    {
        var min = numbers[0];
        
        for (var i = 1; i < numbers.Length; i++)
            if (numbers[i] < min)
                min = numbers[i];
        
        return min;
    }
    
    static void PrintIndicesOfYearInArray(int[] years, int year)
    {
        for (int i = 0; i < years.Length; i++)
            if(years[i] == year)
                Console.WriteLine($"Årtalet found på index {i}");
    }
    
    //-------------Uppgift 5.5-----------------------------------------------------//
    
    /// <summary>
    /// Skapa ett program där användaren ska få skriva in åldern på personerna
    /// i ett hyreshus. Programmet ska först fråga användaren om en ålder.
    /// Därefter ska programmet fråga om användaren vill skriva in en till
    /// ålder och förvänta sig svaret "j" eller "n". Användaren ska få fortsätta
    /// skriva in nya åldrar tills hen svarar "n". Skriv därefter ut alla åldrar
    /// som användaren skrev in.
    /// 
    /// Programmet ska tillåta användaren att skriva in upp till 100 åldrar
    /// utan att krascha, om användaren har skrivit in 100 åldrar ska programmet
    /// skriva ut "Programmet har inte plats för fler åldrar" och därefter skriva
    /// ut alla åldrar som har sparats.
    /// 
    /// https://progsharp.se/kapitel/5/#uppgift-55
    /// </summary>
    static void RunUppgift5_5()
    {
        const int maxAges = 4; // Set this value to 5 in order to test running out of space :)

        var ages = new int[maxAges];
        var agesCount = 0;
        
        do
        {
            if (!IsThereSpaceAvailable(ages, agesCount))
            {
                Console.WriteLine("Programmet har inte plats för fler åldrar");
                break;
            }
            
            ages[agesCount] = ReadInteger("Skriv in age: ");
            agesCount++;

        } while (ConfirmContinue("Vill du fortsätta? ([j]a / [n]ej) "));
        
        Console.WriteLine("Du har skrivit: ");
        PrintAges(ages, agesCount);
    }
    
    static bool ConfirmContinue(string message)
    {
        var userResponse = ReadString(message);
        return userResponse == "j";
    }

    static bool IsThereSpaceAvailable(int[] ages, int ageCount)
    {
        return ageCount < ages.Length;
    }
    
    static void PrintAges(int[] ages, int count)
    {
        for (var i = 0; i < count; i++)
            Console.WriteLine(ages[i]);
    }
    
    //-----------------------------------------------------------------------------//
}