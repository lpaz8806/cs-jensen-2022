namespace Arrays;

partial class Program
{
    /// <summary>
    /// Computes a string representation of the specified array
    /// </summary>
    /// <example>
    /// int[] arr = {1,2,3,4,5} returns
    /// "[1, 2, 3, 4, 5]"
    /// </example>
    /// <param name="items"></param>
    /// <returns></returns>
    public static string ArrayToString<T>(T[] items)
    {
        return $"[{string.Join(", ", items)}]";
    }

    public static void PrintArray<T>(T[] items)
    {
        Console.WriteLine(ArrayToString(items));
    }
    
    public static int ArraySum(int[] numbers)
    {
        var sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            var number = numbers[i];
            sum += number;
        }

        return sum;
    }

    /// <summary>
    /// Returns the largest number in the
    /// specified array of numbers
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int ArrayMax(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new ArgumentException("Empty sh**");

        var max = numbers[0];
        
        for (var i = 0; i < numbers.Length; i++)
        {
            var currentNumber = numbers[i];
            if (currentNumber > max)
                max = currentNumber;
        }

        return max;
    }
}