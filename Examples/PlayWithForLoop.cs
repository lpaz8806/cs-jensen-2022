namespace Examples;

public class PlayWithForLoop
{
    public static void PrintRange()
    {
        for (int i = 40; i <= 80; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void PrintLastOddInRange()
    {
        int lastOdd = 0;
        
        for (int i = 40; i <= 80; i++)
        {
            var isIOdd = i % 2 == 1;
    
            if (isIOdd)
                lastOdd = i;
        }

        Console.WriteLine(lastOdd);
    }
    
    public static void PrintFirstOddInRange()
    {
        int firstOdd = 0;

        for (int i = 40; i <= 80; i++)
        {
            var gotAnOddBefore = firstOdd != 0;
            var isIOdd = i % 2 == 1;
    
            if (isIOdd && !gotAnOddBefore)
                firstOdd = i;
        }

        Console.WriteLine(firstOdd);
    }

    // 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52
    // 5   4    4   3   3   2   2   1   1   0  0   -1    // n
    public static void PrintNthOddInRange()
    {
        int nthOdd = 0;
        int n = 5;
        
        for (int i = 40; i <= 80; i++)
        {
            var isIOdd = i % 2 == 1;
            if (isIOdd)
                n--;
            
            if (isIOdd && n == 0)
                nthOdd = i;
        }
        
        Console.WriteLine(nthOdd);
    }
    
    public static void PrintNthEvenNotDivisibleBy3InRange()
    {
        int nthNumber = 0;
        int n = 5;

        for (int i = 40; i <= 80; i++)
        {
            var iIsNotDivisibleByThree = i % 3 != 0;
            var iIsEven = i % 2 == 0;
            
            var condition = iIsNotDivisibleByThree && iIsEven;
            if (condition)
                n--;
            
            if (condition && n == 0)
                nthNumber = i;
        }
        
        Console.WriteLine(nthNumber);
    }
    
    public static bool IsEven(int n)
    {
        return n % 2 == 0;
    }
    public static bool IsNotDivisibleBy3(int n)
    {
        return n % 3 != 0;
    }
}