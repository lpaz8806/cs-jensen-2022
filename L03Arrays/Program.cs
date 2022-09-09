namespace Arrays;

partial class Program
{
    static void Main(string[] args)
    {
        var m1 = new double[,] { { 2, 3 }, { 4, 5 } };
        var m2 = new double[,] { { 1, 1 }, { 1, 1 } };
        var result = MatrixAdd(m1, m2);

        var strRightAligned = "Hello".PadLeft(10, '_');
        Console.WriteLine(strRightAligned);
        
        var strLeftAligned = "Hello".PadRight(10, '_');
        Console.WriteLine(strLeftAligned);
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