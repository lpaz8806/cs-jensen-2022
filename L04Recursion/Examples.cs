namespace Recursion;

partial class Program
{
    ///<summary>
    /// 1  2  3  4 
    /// 0  1  2  3  4  5
    /// 0, 1, 1, 2, 3, 5, 8, 13...
    /// Fib[1] = 0
    /// Fib[2] = 1
    /// Fib[n] = Fib[n-1] + Fib[n-2]
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static int Fibonacci(int n)
    {
        if (n <= 0)
            throw new ArgumentException();
        
        if (n == 1)
            return 0;
        
        if (n == 2)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    
    static void HanoiMove(int n, int start, int end, int aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move from {start} to {end}");
            return;
        }
        
        HanoiMove(n - 1, start, aux, end);
        HanoiMove(1, start, end, aux);
        HanoiMove(n - 1, aux, end, start);
    }
    
    static int MaxInArray(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new Exception();
        
        if (numbers.Length == 1)
            return numbers[0];
        
        var current = numbers[0];
        var maxRest = MaxInArray(Rest(numbers));
        return current > maxRest ? current : maxRest;
    }
    
    static int[] Rest(int[] arr)
    {
        int[] rest = new int[arr.Length - 1];
        
        for (int i = 0; i < rest.Length; i++)
            rest[i] = arr[i + 1];
        
        return rest;
    }
}