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
        if (x == 0)
            return 0;

        if (x > 0)
            return Neg(x - 1) - 1;
        
        return Neg(x + 1) + 1;
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
        if (n == 0)
            return 1;

        return n * Factorial(n - 1);
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
        var lastDigit = n % 10;
        var nExceptLastDigit = n / 10;
        
        if (n == 0)
            return 0;
        
        return lastDigit + DigitsSum(nExceptLastDigit);
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
        var lastDigit = n % 10;
        var nExceptLastDigit = n / 10;

        var count = lastDigit == d ? 1 : 0;

        var areThereMoreDigitsToExplore = nExceptLastDigit > 0;
        if (areThereMoreDigitsToExplore)
            count += CountDigit(nExceptLastDigit, d);

        return count;
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
        if (str.Length == 0)
            return true;  // It says "zero or more pairs"

        var firstCharIsOpenParenthesis = str[0] == '(';
        var lastCharIsClosedParenthesis = str[^1] == ')';

        if (!firstCharIsOpenParenthesis || !lastCharIsClosedParenthesis)
            return false;
        
        var nestedSubstring = str.Substring(1, str.Length - 2);
        return IsNestedParenthesis(nestedSubstring);
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
        return IsWirth(n, 1);
    }
    static bool IsWirth(int n, int currentWirthNumber)
    {
        if (n == currentWirthNumber)
            return true;

        if (currentWirthNumber > n)
            return false;
        
        return
            IsWirth(n, 2 * currentWirthNumber + 1) ||
            IsWirth(n, 3 * currentWirthNumber + 1);
    }
    
    static bool IsWirthBottomTop(int n)
    {
        return
            n == 1 ||
            n % 2 == 1 && IsWirthBottomTop(n / 2) ||
            n % 3 == 1 && IsWirthBottomTop(n / 3);
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
        ArraySortAsc(numbers, 0);
    }
    static void ArraySortAsc(int[] numbers, int i)
    {
        if(i >= numbers.Length)
            return;

        var iMin = IndexOfMin(numbers, i);
        Swap(numbers, i, iMin);
        ArraySortAsc(numbers, i + 1);
    }
    static int IndexOfMin(int[] numbers, int startIndex)
    {
        var iMin = startIndex;
        for (var i = startIndex; i < numbers.Length; i++)
            if (numbers[i] < numbers[iMin])
                iMin = i;
        return iMin;
    }

    static void Swap(int[] numbers, int i, int j)
    {
        var tmp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = tmp;
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
        ArraySortDesc(numbers, 0);
    }
    static void ArraySortDesc(int[] numbers, int i)
    {
        if(i >= numbers.Length)
            return;

        var iMax = IndexOfMax(numbers, i);
        Swap(numbers, i, iMax);
        ArraySortDesc(numbers, i + 1);
    }
    static int IndexOfMax(int[] numbers, int startIndex)
    {
        var iMax = startIndex;
        for (var i = startIndex; i < numbers.Length; i++)
            if (numbers[i] > numbers[iMax])
                iMax = i;
        return iMax;
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Given a boolean map where true means land and false means
    /// water. Counts the amount of islands in that map.
    /// A single true is a island 
    /// </summary>
    /// <example>
    /// 0 1 0 1
    /// 1 1 0 1     =>  2
    /// 0 0 0 0
    ///
    /// 0 0 0 1
    /// 1 0 0 1     =>  2
    /// 0 0 1 1
    ///
    /// 1 0 0 0
    /// 0 1 0 0     =>  1
    /// 0 0 1 0
    /// </example>
    /// <returns>The amount of islands found</returns>
    static int CountIslands(bool[,] map)
    {
        map = (bool[,])map.Clone();
        
        var count = 0;
        for (int i = 0; i < map.GetLength(0); i++)
        for (int j = 0; j < map.GetLength(1); j++)
        {
            if(!map[i,j]) continue;
            RemoveLand(map, i, j);
            count++;
        }

        return count;
    }

    static void RemoveLand(bool[,] map, int i, int j)
    {
        if (i < 0 || i >= map.GetLength(0)) return;
        if (j < 0 || j >= map.GetLength(1)) return;
        if (!map[i, j]) return;

        map[i, j] = false;
        
        RemoveLand(map, i + 1, j);
        RemoveLand(map, i - 1, j);
        RemoveLand(map, i, j + 1);
        RemoveLand(map, i, j - 1);
    }
    
    //------------------------------------------------------------//
    
    /// <summary>
    /// Computes the area of the largest island in the map
    /// </summary>
    /// /// <example>
    /// 0 1 0 1
    /// 1 1 0 1     =>  3
    /// 0 0 0 0
    ///
    /// 0 0 0 1
    /// 1 0 0 1     =>  4
    /// 0 0 1 1
    ///
    /// 1 0 0 0
    /// 0 1 0 0     =>  3
    /// 0 0 1 0
    /// </example>
    /// <param name="map"></param>
    /// <returns>The area of the largest island in the map</returns>
    static int ComputeAreaOfLargestIsland(bool[,] map)
    {
        map = (bool[,])map.Clone();
        
        var maxArea = 0;
        for (int i = 0; i < map.GetLength(0); i++)
        for (int j = 0; j < map.GetLength(1); j++)
        {
            if(!map[i,j]) continue;
            
            var area = AreaOfIsland(map, i, j);
            if (area > maxArea)
                maxArea = area;
        }

        return maxArea;
    }
    
    static int AreaOfIsland(bool[,] map, int i, int j)
    {
        if (i < 0 || i >= map.GetLength(0)) return 0;
        if (j < 0 || j >= map.GetLength(1)) return 0;
        if (!map[i, j]) return 0;

        map[i, j] = false;

        return 1 +
            AreaOfIsland(map, i + 1, j) +
            AreaOfIsland(map, i - 1, j) +
            AreaOfIsland(map, i, j + 1) +
            AreaOfIsland(map, i, j - 1);
    }
    
    //------------------------------------------------------------//
}