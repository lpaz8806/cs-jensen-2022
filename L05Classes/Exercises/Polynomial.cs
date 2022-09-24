using System.Text;

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
    private long[] coefficients;

    public int Degree => coefficients.Length - 1;

    public Polynomial(params long[] coefficients)
    {
        this.coefficients = coefficients;
    }
    
    public long EvaluateAt(long x)
    {
        var result = 0L;
        for (int i = 0; i < coefficients.Length; i++)
            result += coefficients[i] * (long)Math.Pow(x, i);
        return result;
    }
    
    public Polynomial Add(Polynomial p)
    {
        var maxDegree = Math.Max(Degree, p.Degree);
        var minDegree = Math.Min(Degree, p.Degree);

        var sum = new long[maxDegree];

        for (var i = 0; i < minDegree; i++)
            sum[i] = coefficients[i] + p.coefficients[i];
        
        for (var i = minDegree; i < Degree; i++)
            sum[i] = coefficients[i];
        
        for (var i = minDegree; i < p.Degree; i++)
            sum[i] = p.coefficients[i];

        return new Polynomial(sum);
    }
    public Polynomial Sub(Polynomial p)
    {
        var maxDegree = Math.Max(Degree, p.Degree);
        var minDegree = Math.Min(Degree, p.Degree);

        var sub = new long[maxDegree];

        for (var i = 0; i < minDegree; i++)
            sub[i] = coefficients[i] - p.coefficients[i];

        for (var i = minDegree; i < Degree; i++)
            sub[i] -= coefficients[i];
        
        for (var i = minDegree; i < p.Degree; i++)
            sub[i] -= p.coefficients[i];

        return new Polynomial(sub);
    }
}
