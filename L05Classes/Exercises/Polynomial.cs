namespace L05Classes;

/*
 * Implement a class representing a polynomial on integers of a single variable.
 * 
 * It must support the following features
 * - Evaluate
 * - Add and subtract another Polynomial
 * - Override ToString() to return a "human" readable representation
*/
public class Polynomial
{
    // Think about how can you represent a polynomial in a way
    // that you can operate with it.
    
    // HINT: Look at the coefficients and the exponents and see
    // how you can use the data types you already know to
    // capture the essentials

    // https://sv.wikipedia.org/wiki/Polynom
    // https://en.wikipedia.org/wiki/Polynomial
    
    // OBS: The code to solve this problem is quite simple.
    // Give yourself time to understand the requirements (you may ask if you need). This is the key part
    
    /// <summary>
    /// Evaluates this polynomial at the specified value x
    /// </summary>
    public long EvaluateAt(int x)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Returns the sum of this polynomial
    /// </summary>
    /// <returns>A new polynomial resulting from adding this one and the other one</returns>
    public Polynomial Add(Polynomial q)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Returns the sum of this polynomial
    /// </summary>
    /// <returns>A new polynomial resulting from adding this one and the other one</returns>
    public Polynomial Sub(Polynomial q)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Returns the "human" representation for this polynomial
    /// </summary>
    /// <example>
    /// p.ToString('x') => "x^2 - 4*x + 1"
    /// q.ToString('y') => "-3*y^2 + y + 1"
    /// w.ToString('z') => "-z^3 + z^2 + 1"
    /// </example>
    public string ToString(char varName)
    {
        throw new NotImplementedException();
    }
    
    
    public static Polynomial operator +(Polynomial p, Polynomial q)
    {
        return p.Add(q);
    }
    public static Polynomial operator -(Polynomial p, Polynomial q)
    {
        return p.Sub(q);
    }
    public override string ToString()
    {
        return ToString('x');
    }
}