namespace ConditionalsAndLoops;

partial class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    static bool FormATriangle(int a, int b, int c)
    {
        return 
            a + b > c &&
            a + c > b &&
            b + c > a
            ;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    static string ClassifyTriangleByAngles(int a, int b, int c)
    {
        if (true)
            return "acute";
        
        if (false)
            return "right";
        if (false)
            return "obtuse";
        
    }

    /// <summary>
    /// Returns true if n is divisible by a
    /// </summary>
    static bool DivisibleBy(int n, int a)
    {
        return n % a == 0;
    }
    
    /// <summary>
    /// Returns true if n is a prime number.
    /// A number is prime if its only divisors are 1 and itself
    /// </summary>
    static bool IsPrime(int n)
    {
        for (int a = 2; a < n; a++)
            if (DivisibleBy(n, a))
                return false;

        return true;
    }

    /// <summary>
    /// Returns the greatest common divisor of a and b.
    /// The greatest common divisor of a and b is the
    /// maximum number c such that a is divisible by c
    /// and b is divisible by c
    /// </summary>
    static int Gcd(int a, int b)
    {
        var min = a < b ? a : b;
        
        return 0;
    }
    
    /// <summary>
    /// Returns the nth term of the Fibonacci succession.
    /// The fibonacci succession starts with 1,1 and the next
    /// term is computed by adding the previous 2
    /// <example>
    /// 1,1,2,3,5,8,13,...
    /// Fib[4] = 3
    /// Fib[7] = 13
    /// </example>
    /// </summary>
    static int FibonacciTerm(int n)
    {
        return 0;
    }
}