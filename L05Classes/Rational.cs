namespace L05Classes;

public struct Rational
{
    public static readonly Rational Zero = new Rational(0, 1);
    public static readonly Rational One = new Rational(1, 1);
    
    private int numerator;
    private int denominator;

    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new DivideByZeroException();

        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }
    
    #region Arithmetic Operators
    public static Rational operator +(Rational x, Rational y)
    {
        return new Rational(
            x.numerator * y.denominator + x.denominator * y.numerator,
            x.denominator * y.denominator
        );
    }
    public static Rational operator -(Rational x, Rational y)
    {
        return new Rational(
            x.numerator * y.denominator + x.denominator * y.numerator,
            x.denominator * y.denominator
        );
    }
    
    public static Rational operator *(Rational x, Rational y)
    {
        return new Rational(
            x.numerator * y.numerator,
            x.denominator * y.denominator
        );
    }
    public static Rational operator /(Rational x, Rational y)
    {
        return new Rational(
            x.numerator * y.denominator,
            x.denominator * y.numerator
        );
    }

    #endregion

    #region Comparison operators

    public static bool operator ==(Rational x, Rational y)
    {
        return x.numerator * y.denominator == x.denominator * y.numerator;
    }
    public static bool operator !=(Rational x, Rational y)
    {
        return x.numerator * y.denominator != x.denominator * y.numerator;
    }
    
    #endregion

    #region Cast operators

    public static explicit operator double(Rational x)
    {
        return (double)x.numerator / x.denominator;
    }
    public static explicit operator decimal(Rational x)
    {
        return (decimal)x.numerator / x.denominator;
    }
    
    public static explicit operator Rational(int x)
    {
        return new Rational(x, 1);
    }

    #endregion
    
    public static Rational Parse(string str)
    {
        var parts = str.Split('/',
            StringSplitOptions.TrimEntries);
        
        var numerator = int.Parse(parts[0]);
        var denominator = parts.Length == 2
            ? int.Parse(parts[1])
            : 1;

        return new Rational(numerator, denominator);
    }

    void Simplify()
    {
        
    }

    int Gcd(int x, int y) => y == 0 ? x : Gcd(y, x % y);
    public override string ToString()
    {
        if (numerator == 0)
            return "0";

        if (denominator == 1)
            return numerator.ToString();
        
        return $"{numerator} / {denominator}";
    }
}