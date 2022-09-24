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
        
        Rationalize();
    }
    
    public Rational Reciprocal
    {
        get
        {
            if (numerator == 0)
                throw new Exception();

            return new Rational(denominator, numerator);
        }
    }
    
    #region Arithmetic Operators

    public static Rational operator +(Rational x, Rational y)
    {
        return new Rational(
            x.numerator * y.denominator + x.denominator * y.numerator,
            x.denominator * y.denominator
        );
    }
    
    public static Rational operator -(Rational x)
    {
        return new Rational(-x.numerator, x.denominator);
    }
    public static Rational operator -(Rational x, Rational y)
    {
        return new Rational(
            x.numerator * y.denominator - x.denominator * y.numerator,
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
    
    public static bool operator >(Rational x, Rational y)
    {
        return x.numerator * y.denominator > x.denominator * y.numerator;
    }
    public static bool operator <(Rational x, Rational y)
    {
        return x.numerator * y.denominator < x.denominator * y.numerator;
    }
    
    public static bool operator >=(Rational x, Rational y)
    {
        return x.numerator * y.denominator >= x.denominator * y.numerator;
    }
    public static bool operator <=(Rational x, Rational y)
    {
        return x.numerator * y.denominator <= x.denominator * y.numerator;
    }
    

    #endregion

    #region Cast operators

    public static implicit operator double(Rational x)
    {
        return (double)x.numerator / x.denominator;
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

    /// <summary>
    /// Computes the greatest common divisor of x and y. Useful to simplify fractions.
    /// The greatest common divisor of two numbers is the largest integer that divides
    /// both of them
    /// </summary>
    private static int Gcd(int x, int y)
    {
        while (y != 0)
        {
            var oldX = x;
            x = y;
            y = oldX % y;
        }

        return x;
    }

    private void Rationalize()
    {
        var sign = numerator < 0 ^ denominator < 0 ? -1 : 1;
        
        numerator = Math.Abs(numerator);
        denominator = Math.Abs(denominator);
        var gcd = Gcd(numerator, denominator);
        
        numerator = sign * (numerator / gcd);
        denominator /= gcd;
    }
    
    public override string ToString()
    {
        return $"{numerator} / {denominator}";
    }
}