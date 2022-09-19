namespace L05Classes;

public struct Rational
{
    private int numerator;
    private int denominator;

    public Rational(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public Rational Multiply(Rational y)
    {
        return new Rational(
            numerator * y.numerator,
            denominator * y.denominator
        );
    }
    public Rational Multiply(int y)
    {
        return new Rational(
            numerator * y,
            denominator
        );
    }

    public static Rational operator *(Rational x, Rational y)
    {
        return x.Multiply(y);
    }
    public static Rational operator *(Rational x, int y)
    {
        return x.Multiply(y);
    }
    
    public static implicit operator double(Rational x)
    {
        return (double)x.numerator / x.denominator;
    }
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

    public override string ToString()
    {
        return $"{numerator} / {denominator}";
    }
}