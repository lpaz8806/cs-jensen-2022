// See https://aka.ms/new-console-template for more information

/*
Skriv ett program som beräknar växeln man får tillbaka när man har betalat för sina varor. 
Vid utskriften anges vilka sedlar och mynt  köparen får tillbaka. 
Inmatningen ska vara priset som ska betalas och beloppet köparen har betalat.
Programmet ska skriva ut antal 1000-, 500-, 100-, 50- och 20- sedlar
och antal 10-, 5-, 1- kronorsmynt man får som växel.

Vi utgår från att 50 öre fortfarande används. Växeln avrundas till närmsta 50 öre.
Om antalet öre är < 25 avrundas växeln neråt till 0, om det ligger mellan 25 och 75 avrundas växeln 
till 50 öre och om det är >75 avrundas växeln upp till en krona.
*/

class Program
{
    static readonly Dictionary<int, string> Sedlar = new()
    {
        { ConvertToOre(1000), "1000-" },
        { ConvertToOre(500), "500-" },
        { ConvertToOre(100), "100-" },
        { ConvertToOre(50), "50-" },
        { ConvertToOre(10), "10-" },
        { ConvertToOre(5), "5-" },
        { ConvertToOre(1), "1-" },
        { ConvertToOre(0.5m), "0.50-" },
    };
    
    static void Main(string[] args)
    {
        decimal x = 10.35m;
        decimal y = 10m;
        Console.WriteLine(x / y);
        return;
        
        
        var price = ReadInput("Price: ");
        var amountPaid = ReadInput("You paid: ");
        
        var amountToReturn = ConvertToOre(Round(amountPaid - price));
        var cashBack = ComputeCashBack(amountToReturn);
        PrintCashBack(cashBack);
        
    }
    
    static decimal Round(decimal amount)
    {
        var intPart = Math.Floor(amount);
        var decimalPart = amount - intPart;

        if (decimalPart < 0.25m)
            decimalPart = 0;
        else if (decimalPart < 0.75m)
            decimalPart = 0.5m;
        else
            decimalPart = 1.0m;

        return intPart + decimalPart;
    }

    static int ConvertToOre(decimal amount)
    {
        return (int)(amount * 100);
    }

    static IDictionary<int, int> ComputeCashBack(int amountInOre)
    {
        var cashBack = new Dictionary<int, int>();
        
        foreach (var sedel in Sedlar)
        {
            var count = amountInOre / sedel.Key;
            amountInOre %= sedel.Key;
            cashBack.Add(sedel.Key, count);
        }

        return cashBack;
    }

    static void PrintCashBack(IDictionary<int, int> cashBack)
    {
        foreach (var item in cashBack)
        {
            Console.WriteLine($"{Sedlar[item.Key]}: {item.Value}");
        }
    }

    static decimal ReadInput(string message)
    {
        Console.Write(message);
        return decimal.Parse(Console.ReadLine() ?? string.Empty);
    }
}
