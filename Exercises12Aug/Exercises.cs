namespace Exercises12Aug;

partial class Program
{
    /// <summary>Creates a copy of the specified array</summary>
    /// <returns>A new array containing the same elements as the source</returns>
    public static T[] ArrayClone<T>(T[] source)
    {
        var clone = new T[source.Length];
        
        for (int i = 0; i < source.Length; i++)
            clone[i] = source[i];

        return clone;
    }
    
    static T[] _ArrayClone<T>(T[] source)
    {
        var clonedArray = new T[source.Length];
        
        for (int i = 0; i < source.Length; i++)
            clonedArray[i] = source[i];
        
        return clonedArray;
    }
    
    //-----------------------------------------------------------------------------//
    
    /// <summary>
    /// Determines whether the specified array contains the specified item
    /// </summary>
    /// <param name="items">The array of items</param>
    /// <param name="item">The item to search for</param>
    /// <returns>True if the array contains the item. False otherwise</returns>
    public static bool ArrayContains(int[] items, int item)
    {
        return _ArrayContains(items, item);
    }
    
    static bool _ArrayContains(int[] items, int item)
    {
        for (int i = 0; i < items.Length; i++)
            if (items[i] == item)
                return true;

        return false;
    }
    
    //-----------------------------------------------------------------------------//
    
    /// <summary>
    /// Starting at index, returns a portion of the specified size
    /// </summary>
    /// <example>
    /// int[] items = {1,2,4,8,16,32,64}
    /// ArraySlice(items, 1, 3) returns [2,4,8]
    /// ArraySlice(items, 1, 0) returns []
    /// </example>
    /// <remarks>This method DOES NOT modify the original array (items)</remarks>
    /// <param name="items"></param>
    /// <param name="i">The index where slice starts</param>
    /// <param name="size">The size of the slice</param>
    /// <returns></returns>
    public static T[] ArraySlice<T>(T[] items, int i, int size)
    {
        var slice = new T[size];
        
        for (int j = 0; j < size; j++)
            slice[j] = items[i + j];
        
        return slice;
    }

    static T[] _ArraySlice<T>(T[] items, int i, int size)
    {
        var slice = new T[size];
        
        for (int j = 0; j < size; j++)
            slice[j] = items[i + j];

        return slice;
    }
    
    //-----------------------------------------------------------------------------//
    
    /// <summary>
    /// Prints in the console a right triangle with the specified height
    /// Source: https://progsharp.se/kapitel/4/#uppgift-429
    /// </summary>
    /// <example>
    /// Om användaren till exempel anger sidlängden 5 så ska följande triangel ritas ut:
    /// *
    /// **
    /// ***
    /// ****
    /// *****
    /// </example>
    /// <returns></returns>
    public static void PrintRightTriangle(int height)
    {
        string str = string.Empty;
        for (int i = 0; i < height; i++)
        { 
            str += "*";
            Console.WriteLine(str);
        }
        
        // _PrintRightTriangleNestedLoops(height);
    }

    static void _PrintRightTriangleNestedLoops(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write('*');

            Console.WriteLine();
        }
    }
    
    static void _PrintRightTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            PrintCharNTimes('*', i);
            Console.WriteLine();
        }
    }
    private static void PrintCharNTimes(char c, int n)
    {
        for (int j = 0; j < n; j++)
            Console.Write(c);
    }
    
    //-----------------------------------------------------------------------------//
    
    /// <summary>
    /// Determines whether the specified string is a palindrome.
    /// A palindrome is a string that reads the same from left to
    /// right than from right to left
    /// </summary>
    /// <example>
    /// "anna" is a palindrome
    /// "amna" is not a palindrome
    /// </example>
    /// <param name="word"></param>
    /// <returns>true if the argument is a palindrome, false otherwise</returns>
    public static bool IsPalindrome(string word)
    {
        var str = string.Empty;
        for (int i = 0; i < word.Length; i++)
        {
            str = word[i] + str;
        }
        
        var j = word.Length - 1;
        for (int i = j; i >= 0; i--)
            str += word[i];

        return str == word;

        // return _IsPalindromeWithLoopsNaive(word);
        // return _IsPalindromeWithLoops(word);
        // return _IsPalindromeWithHomeMadeReverse(word);
        // return _IsPalindromeWithLoopsClean(word);

    }
    
    static bool _IsPalindromeWithLoopsNaive(string word)
    {
        for (int i = 0; i < word.Length; i++)
            if (word[i] != CharInReverse(word, i)) // char in reverse
                return false;
        
        return true;
    }
    static bool _IsPalindromeWithLoops(string word)
    {
        word = word.ToLower();
        var halfWordLength = word.Length / 2;
        
        for (int i = 0; i < halfWordLength; i++)
            if (word[i] != word[word.Length - 1 - i])
                return false;
        
        return true;
    }
    static bool _IsPalindromeWithHomeMadeReverse(string word)
    {
        return word.Equals(
            ReverseString(word), 
            StringComparison.InvariantCultureIgnoreCase
        );
    }
    static bool _IsPalindromeWithLoopsClean(string word)
    {
        var reversedWord = new string(word.Reverse().ToArray());
        return word.Equals(reversedWord, StringComparison.CurrentCultureIgnoreCase);
    }

    static string ReverseString(string word)
    {
        var reversedString = string.Empty;
        
        for (int i = 0; i < word.Length; i++)
            reversedString = word[i] + reversedString;

        return reversedString;
    }
    static char CharInReverse(string word, int i)
    {
        var lastIndexInWord = word.Length - 1;
        return word[lastIndexInWord - i];
    }
    
    //-----------------------------------------------------------------------------//
    
    /// <summary>Reverses the specified array.</summary>
    /// <example>
    /// Before: arr = {1,2,3,4}
    /// After ArrayReverse(arr) : arr = {4,3,2,1}
    /// </example>
    public static void ArrayReverse<T>(T[] items)
    {
        _ArrayReverse(items);
    }
    
    static void _ArrayReverse<T>(T[] items)
    {
        for (int i = 0; i < items.Length / 2; i++)
        {
            var targetIndex = items.Length - i - 1;
            var temp = items[i];
            items[i] = items[targetIndex];
            items[targetIndex] = temp;
        }
    }

    //-----------------------------------------------------------------------------//
    
    /// <summary>Prints in the console a right triangle with the specified
    /// height</summary>
    /// <example>
    /// Om användaren till exempel anger sidlängden 5 så ska följande triangel ritas ut:
    ///     *
    ///    ***
    ///   *****
    ///  *******
    /// *********
    /// </example>
    /// <returns></returns>
    public static void PrintIsoscelesTriangle(int height)
    {
        PrintIsoscelesTriangleJohan(height);
    }

    public static void PrintIsoscelesTriangleJohan(int height)
    {
        var stars = "*";
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine(stars.PadLeft(height + i, '_'));
            stars += "**";
        }
    }
    
    static void _PrintIsoscelesTrianglePadLeft(int height)
    {
        for (int line = 1; line <= height; line++)
        {
            var starsCount = 2 * line - 1;
            var spacesCount = height - line;
            
            var lineString = ""
                .PadLeft(starsCount, '*')
                .PadLeft(starsCount + spacesCount, ' ');
            
            Console.WriteLine(lineString);
        }
    }
    static void _PrintIsoscelesTriangle(int height)
    {
        for (int line = 1; line <= height; line++)
        {
            var starsCount = 2 * line - 1;
            var spacesCount = height - line;
            PrintCharNTimes(' ', spacesCount);
            PrintCharNTimes('*', starsCount);
            Console.WriteLine();
        }
    }
    //-----------------------------------------------------------------------------//
    
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
        int nthSmallest = -1;
        
        for (int i = 0; i < n; i++)
        {
            nthSmallest = Min(numbers);
            Remove(numbers, nthSmallest);
        }

        return nthSmallest;
        //return _NthSmallest(numbers, n);
    }

    static int Min(int[] numbers)
    {
        return numbers.Min();
    }
    static int[] Remove(int[] numbers, int element)
    {
        return null;
    }
    
    static int _NthSmallest(int[] numbers, int n)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            var currentNumber = numbers[i];
            var smallerCount = _CountSmaller(numbers, currentNumber);
            var equalsCount = _CountEquals(numbers, currentNumber);

            if (smallerCount < n && n <= smallerCount + equalsCount)
                return currentNumber;
        }

        return -1; // this line is unreachable
    }
    
    static int _CountSmaller(int[] numbers, int n)
    {
        var count = 0;
        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] < n)
                count++;
        return count;
    }
    static int _CountEquals(int[] numbers, int n)
    {
        var count = 0;
        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] == n)
                count++;
        return count;
    }
    
    //-----------------------------------------------------------------------------//
    
    /// <summary>
    /// Replaces all occurrences of a substring consisting of one
    /// character by the character alone.
    /// This means, when one character appears more than once
    /// consecutively (no other different character in the middle)
    /// then those extra repeated characters are removed
    /// </summary>
    /// <example>
    /// RemoveDuplicates("aaaabccde") returns "abcde"
    /// RemoveDuplicates("qwertyq") returns "qwertyq"
    /// RemoveDuplicates("abacbc") returns "abacbc"
    /// RemoveDuplicates("grattis") returns "gratis"
    /// RemoveDuplicates("aabcaa") returns "abca"
    /// </example>
    /// <returns></returns>
    public static string RemoveDuplicates(string str)
    {
        return _RemoveDuplicatesCool(str);
    }
    
    static string _RemoveDuplicatesCool(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
            
        var output = string.Empty;
        
        for (int i = 0; i < str.Length - 1; i++)
            if (str[i] != str[i + 1])
                output += str[i];

        output += str[str.Length - 1];
        return output;
    }
    
    static string _RemoveDuplicates(string str)
    {
        var result = string.Empty;

        for (int i = 0; i < str.Length; i++)
        {
            var count = _CountConsecutiveCharsAt(str, i);
            result += str[i];
            i += count;
        }

        return result;
    }

    static int _CountConsecutiveCharsAt(string str, int i)
    {
        int count = 0;

        for (int j = i + 1; j < str.Length; j++)
        {
            if (str[i] != str[j])
                break;

            count++;
        }

        return count;
    }
}
