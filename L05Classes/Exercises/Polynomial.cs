using System.Diagnostics;
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
    private long[] _coefficients;

    public int Degree => _coefficients.Length - 1;

    public Polynomial(params long[] coefficients)
    {
        _coefficients = (long[]) coefficients.Clone();
    }
    
    public long Evaluate(long x)
    {
        var result = _coefficients[0];
        
        // Evaluate using Horner's method
        for (var i = 1; i <= Degree; i++)
            result = result * x + _coefficients[i];
 
        return result;
    }
    
    public static Polynomial operator +(Polynomial p, Polynomial q)
    {
        var degreeOfSum = Math.Max(p.Degree, q.Degree);
        var coefficientsSum = p.CloneCoefficientsAndEnsureDegree(degreeOfSum);
        
        for (var i = 0; i <= q.Degree; i++)
            coefficientsSum[i] += q._coefficients[i];
        
        return new Polynomial(coefficientsSum);
    }
    public static Polynomial operator -(Polynomial p, Polynomial q)
    {
        var degreeOfSum = Math.Max(p.Degree, q.Degree);
        var coefficientsSum = p.CloneCoefficientsAndEnsureDegree(degreeOfSum);
        
        for (var i = 0; i <= q.Degree; i++)
            coefficientsSum[i] += q._coefficients[i];
        
        return new Polynomial(coefficientsSum);
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        
        for (var exp = Degree; exp >= 0; exp--)
            if (_coefficients[exp] != 0)
                sb.Append($"+{_coefficients[exp]} * x^{exp}");
        
        if (sb.Length == 0)
            return "0";

        Beautify(sb);
        return sb.ToString();
    }

    private void Beautify(StringBuilder sb)
    {
        sb.Replace("+-", "-");                  // Make +- to be -
        sb.Replace("+", string.Empty, 0, 1);    // remove + at start
        sb.Replace(" * x^0", string.Empty);     // remove * x^0
        sb.Replace("1 * x", "x");               // make 1 * x to be x
        sb.Replace("x^1", "x");                 // make x^1 to be x
        sb.Replace("-", " - ");                 // add spaces around -
        sb.Replace("+", " + ");                 // add spaces around +
        sb.Replace(" - ", "-", 0, 3);           // remove extra spaces around - in first term
    }
    
    
    private long[] CloneCoefficientsAndEnsureDegree(int newDegree)
    {
        var coefficients = new long[newDegree + 1];
        Array.Copy(_coefficients, coefficients, Degree + 1);
        return coefficients;
    }
}
