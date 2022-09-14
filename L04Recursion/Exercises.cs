namespace Recursion;

partial class Program
{
    //-----------------------------------------//
    /// <summary>
    /// Computes the subtraction of x and y.
    /// Assume x and y nonnegatives
    /// </summary>
    static int Sub(int x, int y)
    {
        if (y == 0)
            return x;

        return Sub(x - 1, y - 1);
    }
    
    //-----------------------------------------//
    /// <summary>Computes the product of x and y</summary>
    static int Mul(int x, int y)
    {
        if (y == 0)
            return 0;

        return Add(x, Mul(x, y - 1));
    }
    
    //-----------------------------------------//
    /// <summary>
    /// Computes the integer division of x and y
    /// </summary>
    static int Div(int x, int y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        
        if (x < y)
            return 0;

        return 1 + Div(Sub(x, y), y);
    }
    
    //-----------------------------------------//
    /// <summary>
    /// Computes the reminder in the division
    /// of x by y
    /// </summary>
    static int Mod(int x, int y)
    {
        if (y == 0)
            throw new DivideByZeroException();
        
        if (x < y)
            return x;

        return Mod(Sub(x, y), y);
    }
    
    //-----------------------------------------//
    /// <summary>
    /// Computes n to the power of k
    /// </summary>
    /// <example>
    /// Pow(0, 8) = 0
    /// Pow(5, 0) = 1
    /// Pow(2, 3) = 8
    /// </example>
    /// <param name="n">The base</param>
    /// <param name="k">The exponent</param>
    /// <returns>n to the power of k</returns>
    static int Pow(int n, int k)
    {
        if (k == 0)
            return 1;
        
        return Mul(n, Pow(n, k - 1));
    }
    
    //--------------------------------------------------//
    
    /// <summary>
    /// Determines whether the specified array
    /// contains the specified number or not
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    static bool ArrayContains(int[] numbers, int n)
    {
        throw new NotImplementedException();
    }
    
    //--------------------------------------------------//
    
    // Compute it recursively
    static bool IsPalindrome(string word)
    {
        if (word.Length < 2)
            return true;
        
        return
            word[0] == word[word.Length - 1] &&
            IsPalindrome(word.Substring(1, word.Length - 2));
    }

    //--------------------------------------------------//
    
    /// <summary>
    /// Converts the specified number to a binary string
    /// </summary>
    /// <example>
    /// DecimalToBinary(0) => "0"
    /// DecimalToBinary(1) => "1"
    /// DecimalToBinary(4) => "100"
    /// DecimalToBinary(5) => "101"
    /// </example>
    static string DecimalToBinary(int n)
    {
        throw new NotImplementedException();
    }
    
    //--------------------------------------------------//
    
    /// <summary>
    /// Returns the index of n in the specified
    /// array. If n is not in the array, -1 is
    /// returned.
    /// 
    /// Assume that the numbers are sorted
    /// </summary>
    static int BinarySearch(int[] numbers, int n)
    {
        // compute it recursively
        // OBS: NUMBERS ARE SORTED!
        throw new NotImplementedException();
    }
}