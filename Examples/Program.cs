// See https://aka.ms/new-console-template for more information

using Examples;

// PlayWithForLoop.PrintNthEvenNotDivisibleBy3InRange();

/*
1  2
3  4
*/

/*
1,2556      2  
     3    4,2809765  
*/


string MatrixToString<T>(T[,] matrix)
{
    string str = string.Empty;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            var cell = matrix[i, j];
            str += cell.ToString();
            str += "  ";
        }

        str += Environment.NewLine;
    }

    return str;
}

void PrintMatrix<T>(T[,] matrix)
{
    Console.WriteLine(MatrixToString(matrix));
}

// double[,] m1 = {{1.2556, 2}, {3,4.2809765}};
// PrintMatrix(m1);

int FibonacciTerm(int n)
{
    if (n < 1)
        return n;

    var f1 = 0;
    var f2 = 1;

    for (int i = 1; i < n; i++)
    {
        var f = f1 + f2;
        f1 = f2;
        f2 = f;
    }
        
    return f2;
}
