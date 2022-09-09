namespace Arrays;

partial class Program
{
    static void Main(string[] args)
    {
        var c = "\x2588\x2588";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(c);
        
        var d = "\x2588\x2588";
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(c);
        
        return;
        
        
        var m1 = new double[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
        var m2 = new double[,]
        {
            { 10, 11, 12 },
            { 20, 21, 22 }
        };
        var m3 = new double[,] {{10, 11}, {20, 21}, {30, 31}};
        
        var sum = MatrixAdd(m1, m2);
        var product = MatrixMult(m1, m3);
        
        PrintMatrix(product);
    }

    
    
    public static bool IsPalindrome(string word)
    {
        throw new NotImplementedException();
    }
    
    static int Add(int x, params int[] args)
    {
        var sum = x;
        for (int i = 0; i < args.Length; i++)
            sum += args[i];

        return sum;
    }
    
    static int[] InitializeArray()
    {
        var c = new int[5];
        c[0] = 2;
        c[1] = 3;
        c[2] = 5;
        c[3] = 7;
        c[4] = 11;
        
        return c;
    }

    static string[] GetTheThreeTenors()
    {
        string[] theThreeTenors = {
            "Placido Domingo",
            "Jose Carreras",
            "Luciano Pavarotti"
        };
        return theThreeTenors;
    }
}

enum Piece
{
    Empty,
    BlackPawn,
    WhitePawn,
    BlackQueen,
    WhiteQueen,
}