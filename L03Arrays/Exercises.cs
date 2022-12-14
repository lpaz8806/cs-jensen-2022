namespace Arrays;

partial class Program
{
    #region Warming up
    /// <summary>
    /// Finds the smallest number in the specified array
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int Minimum(int[] numbers)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Finds the second smallest number in the specified array
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int SecondSmallest(int[] numbers)
    {
        var m1 = Math.Min(numbers[0], numbers[1]);
        var m2 = Math.Max(numbers[0], numbers[1]);
    
        for (int i = 2; i < numbers.Length; i++)
        {
            var n = numbers[i];
        
            if (n <= m1)
            {
                m2 = m1;
                m1 = n;
            }
            else if(n < m2)
            {
                m2 = n;
            }
        }
    
        return m2;
    }
    
    /// <summary>
    /// Finds the nth smallest number in the specified array.
    /// </summary>
    /// <example>
    /// NthSmallest([3,5,2,8,4], 1) returns 2
    /// NthSmallest([3,5,2,8,4], 2) returns 3
    /// NthSmallest([3,5,2,8,4], 5) returns 8
    /// </example>
    /// <returns></returns>
    public static int NthSmallest(int[] numbers, int n)
    {
        return default;
    }
    
    #endregion

    #region MyRegion

    /// <summary>
    /// Berättar om något av tecknen som finns i ordet endast förekommer en gång.
    /// https://progsharp.se/kapitel/4/#uppgift-414
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    static bool ContainsSomeCharacterOnlyOnce(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            var count = 0;
            for (int j = 0; j < word.Length; j++)
                if (word[i] == word[j])
                    count++;

            if (count == 1)
                return true;
        }

        return false;
    }
    
    static bool ContainsSomeCharacterOnlyOnceClean(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            var currentCharInWord = word[i];
            if (CountChar(word, currentCharInWord) == 1)
                return true;
        }

        return false;
    }
    static int CountChar(string word, char c)
    {
        var count = 0;
        
        for (int i = 0; i < word.Length; i++)
            if (word[i] == c)
                count++;
        
        return count;
    }

    #endregion
    
    #region Operations on arrays
    /// <summary>
    /// Creates a copy of the specified array
    /// </summary>
    /// <param name="input"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T[] ArrayClone<T>(T[] input)
    {
        var output = new T[input.Length];
        
        for (var i = 0; i < output.Length; i++)
            output[i] = input[i];

        return output;
    }
    
    /// <summary>
    /// Swaps the element at index i and the element at index j on the
    /// specified array
    /// </summary>
    /// <example>
    /// items = [1,2,3,4,5];
    /// ArraySwapItems(items, 0, 2) 
    /// items == [3, 2, 1, 4, 5] (array items after swap)
    /// </example>
    /// <param name="items"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    public static void ArraySwapItems<TItem>(TItem[] items, int i, int j)
    {
        var temp = items[i];
        items[i] = items[j];
        items[j] = temp;
    }

    /// <summary>
    /// Determines whether the specified array contains the specified item
    /// </summary>
    /// <param name="items">The array of items</param>
    /// <param name="item">The item to search for</param>
    /// <returns>True if the array contains the item. False otherwise</returns>
    public static bool ArrayContains(int[] items, int item)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="items"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public static int ArrayFirstIndexOf(int[] items, int item)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Reverses the specified array
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    public static void ReverseArray<T>(T[] items)
    {
        for (int i = 0; i < items.Length / 2; i++)
        {
            var tmp = items[i];
            items[i] = items[items.Length - i];
            items[items.Length - i] = tmp;
        }
    }
    
    /// <summary>
    /// Reverses the specified array
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    public static T[] ComputeArrayReverse<T>(T[] items)
    {
        var result = ArrayClone(items);
        ReverseArray(result);
        return result; 
    }

    /// <summary>
    /// 
    /// </summary>
    /// <example>
    /// 
    /// </example>
    /// <param name="items"></param>
    /// <param name="i">The index where slice starts</param>
    /// <param name="size">The size of the slice</param>
    /// <returns></returns>
    public static int[] ArraySlice(int[] items, int i, int size)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Sorts the specified
    /// </summary>
    /// <param name="items"></param>
    /// <returns>A copy of the input array in which the elements are sorted ascending</returns>
    public static int[] ArraySort(int[] items)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Sorts the specified array ascending
    /// </summary>
    /// <param name="items"></param>
    /// <exception cref="NotImplementedException"></exception>
    public static void ArraySortInPlace(int[] items)
    {
        throw new NotImplementedException();
    }
    
    
    
    
    #endregion
    
    #region Polynomials
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="exp"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static int Exp(int a, int exp)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Evaluates the specified polynomial at the given point x.
    ///
    /// The polynomial is represented by an array in which the
    /// indices represent the degree (exponent) and the values
    /// represent the coefficients
    /// </summary>
    /// <example>
    /// The polynomial x^2 + 2*x + 4 is represented as [4, 2, 1]
    /// </example>
    /// <param name="polynomial"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int Evaluate(int[] polynomial, int x)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public static int[] AddPolynomials(int[] p, int[] q)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Multiples the specified polynomials.
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns>The product of the input polynomials</returns>
    public static int[] MultiplyPolynomials(int[] p, int[] q)
    {
        throw new NotImplementedException();
    }
    
    
    #endregion
    
    #region Matrix Operations
    
    public static string MatrixToString<T>(T[,] matrix)
    {
        string str = string.Empty;
    
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                var cell = matrix[i, j];
                str += $"{cell}  ";
            }

            str += Environment.NewLine;
        }

        return str;
    }

    public static void PrintMatrix<T>(T[,] matrix)
    {
        Console.WriteLine(MatrixToString(matrix));
    }
    
    public static double[,] MatrixAdd(double[,] m, double[,] n)
    {
        var dim0 = m.GetLength(0);
        var dim1 = m.GetLength(1);

        if (n.GetLength(0) != dim0)
            throw new ArgumentException();
        
        if (n.GetLength(1) != dim1)
            throw new ArgumentException();

        var result = new double[dim0, dim1];
        for (int i = 0; i < dim0; i++)
        {
            for (int j = 0; j < dim1; j++)
                result[i, j] = m[i, j] + n[i, j];
        }

        return result;
    }
    
    public static double[,] MatrixSub(double[,] m, double[,] n)
    {
        var dim0 = m.GetLength(0);
        var dim1 = m.GetLength(1);

        if (n.GetLength(0) != dim0)
            throw new ArgumentException();
        
        if (n.GetLength(1) != dim1)
            throw new ArgumentException();

        var result = new double[dim0, dim1];
        for (int i = 0; i < dim0; i++)
        {
            for (int j = 0; j < dim1; j++)
                result[i, j] = m[i, j] - n[i, j];
        }

        return result;
    }

    /// <summary>
    /// Determines whether the specified matrices can be multiplied.
    /// 
    /// Let's represent a matrix M of m columns and n rows this way:
    /// M[m, n]
    /// 
    /// Two matrices A[m1, m2] and B[n1, n2] can be multiplied if
    /// the amount of rows of A (m2) is equal to the amount of
    /// columns of B (n1)
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static bool CanMultiplyMatrix(double[,] m, double[,] n)
    {
        return m.GetLength(0) == n.GetLength(1);
    }
    
    public static double[,] MatrixMult(double[,] m, double[,] n)
    {
        if (!CanMultiplyMatrix(m, n))
            throw new ArgumentException();

        var resultRowsCount = m.GetLength(0);
        var vectorsLength = m.GetLength(1);
        var resultColsCount = n.GetLength(1);

        var product = new double[resultRowsCount, resultColsCount];
        for (int row = 0; row < resultRowsCount; row++)
        for (int col = 0; col < resultColsCount; col++)
        for (int k = 0; k < vectorsLength; k++)
            product[row, col] += m[row, k] * n[k, col];

        return product;
    }
    
    #endregion
    
}