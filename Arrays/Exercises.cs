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
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Finds the nth smallest number in the specified array
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int NthSmallest(int[] numbers, int n)
    {
        throw new NotImplementedException();
    }
    
    

    #endregion
    
    #region Operations on arrays
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
    public static void ArraySwapItems(int[] items, int i, int j)
    {
        
    }
    
    /// <summary>
    /// Determines whether the specified array contains the specified item
    /// </summary>
    /// <param name="items">The array of items</param>
    /// <param name="item">The item to search for</param>
    /// <returns>True if the array contains the item. False otherwise</returns>
    public static int ArrayContains(int[] items, int item)
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
    public static void ReverseArray(int[] items)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Reverses the specified array
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    public static int[] ComputeArrayReverse(int[] items)
    {
        throw new NotImplementedException();
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
    
    public static double[,] MatrixAdd(double[,] m, double[,] n)
    {
        throw new NotImplementedException();
    }
    
    public static double[,] MatrixSub(double[,] m, double[,] n)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
    
    public static double[,] MatrixMult(double[,] m, double[,] n)
    {
        throw new NotImplementedException();
    }
    
    #endregion
    
}