namespace Recursion;

partial class Program
{
    /// <summary>Computes the opposite of x</summary>
    /// <remarks>Use only +1 or -1 in your implementation</remarks>
    /// <example>
    /// Neg(0) = 0
    /// Neg(-5) = 5
    /// Neg(8) = -8
    /// </example>
    static int Neg(int x)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Computes the factorial of n. The
    /// factorial of n is defined as the product
    /// from 1 to n and the factorial of 0 is 1.
    /// Factorial(n) = 1 * 2 * ... * n
    /// </summary>
    /// <remarks>
    /// When testing this method, use numbers
    /// from 0 to 65. This numbers grows very
    /// rapidly and overflows the ulong capacity
    /// </remarks>
    /// <example>
    /// Factorial(0) = 1
    /// Factorial(1) = 1
    /// Factorial(3) = 6
    /// Factorial(5) = 120
    /// </example>
    static ulong Factorial(ulong n)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Computes the sum of the digits of the specified
    /// non-negative number.
    ///
    /// Hint: Given a number, how to compute its least significant
    /// digit? (the right-most digit)
    /// </summary>
    /// <example>
    /// DigitsSum(1) = 1
    /// DigitsSum(12) = 3
    /// DigitsSum(135) = 9
    /// DigitsSum(2022) = 6
    /// </example>
    static int DigitsSum(int n)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Counts the number of occurrences of the digit d in n.
    /// Assume n >= 0 and d between 0 and 9
    /// </summary>
    /// <example>
    /// CountDigit(0, 0) = 1
    /// CountDigit(10, 0) = 1
    /// CountDigit(1, 1) = 1
    /// CountDigit(1233, 3) = 2
    /// CountDigit(11325345, 8) = 0
    /// </example>
    static int CountDigit(int n, int d)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Given a string, return true if it is a nesting of zero
    /// or more pairs of parenthesis
    /// </summary>
    /// <example>
    /// IsNestedParenthesis("") == true
    /// IsNestedParenthesis("()") == true
    /// IsNestedParenthesis("()(") == false
    /// IsNestedParenthesis("(x)") == false
    /// IsNestedParenthesis("(())") == true
    /// IsNestedParenthesis("((()))") == true
    /// IsNestedParenthesis("((())w)") == false
    /// </example>
    static bool IsNestedParenthesis(string str)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Determines whether the specified number
    /// is a Wirth number.
    /// 
    /// Definition:
    /// - 1 is Wirth
    /// - if k (int) is Wirth then
    ///   2 * k + 1 is Wirth and
    ///   3 * k + 1 is Wirth
    /// </summary>
    /// <example>
    /// 1, 3, 4, 7, 9, 10, 13 ... are Wirth
    /// </example>
    /// <returns>true if n is a Wirth number, false otherwise</returns>
    static bool IsWirth(int n)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Sorts the specified array in ascending order
    /// </summary>
    /// <example>
    /// Sort({1,5,2,6,3,4}) -- after sort --> {1,2,3,4,5,6}
    /// </example>
    static void ArraySortAsc(int[] numbers)
    {
        throw new NotImplementedException();
    }

    //------------------------------------------------------------//
    
    /// <summary>
    /// Sorts the specified array in descending order
    /// </summary>
    /// <example>
    /// Sort({1,5,2,6,3,4}) => {6,5,4,3,2,1}
    /// </example>
    static void ArraySortDesc(int[] numbers)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="map"></param>
    /// <returns>The amount of islands found</returns>
    static int CountIslands(bool[,] map)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="map"></param>
    /// <returns>The area of the largest island in the map</returns>
    static int ComputeAreaOfLargestIsland(bool[,] map)
    {
        throw new NotImplementedException();
    }
    
    //------------------------------------------------------------//
}