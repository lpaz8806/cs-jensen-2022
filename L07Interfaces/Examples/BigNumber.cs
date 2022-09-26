namespace L07Interfaces.Examples;

public class BigNumber
{
    private string _digits;

    public BigNumber(string digits)
    {
        if (!IsInteger(digits))
            throw new ArgumentException("Not an int dude!");

        _digits = digits.TrimStart('0');
    }
    
    public int this[int i]
    {
        get
        {
            return i >= _digits.Length
                ? 0
                : _digits[_digits.Length - i - 1] - '0';
        }
    }
    public int Length => _digits.Length;

    public static BigNumber operator +(BigNumber x, BigNumber y)
    {
        var maxLength = Math.Max(x.Length, y.Length) + 1;
        var digits = string.Empty;
        
        var carry = 0;
        for (int i = 0; i < maxLength; i++)
        {
            var currentDigit = Add(x[i], y[i], ref carry);
            digits = currentDigit + digits;
        }

        return new BigNumber(digits);
    }
    
    private static char Add(int d1, int d2, ref int carry)
    {
        var sum = d1 + d2 + carry;
        var result = sum % 10;
        carry = sum / 10;
        return (char)(result + '0');
    }
    
    private bool IsInteger(string digits)
    {
        foreach (var d in digits)
            if (!char.IsDigit(d))
                return false;
        
        return true;
    }

    public override string ToString()
    {
        return _digits;
    }
}
