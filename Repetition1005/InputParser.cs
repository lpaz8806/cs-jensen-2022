using System.Text;

namespace Repetition1005;

public class InputParser
{
    private const string AllowedOperators = "+-:*";
    /// <summary>
    /// operand
    /// operand operator operand
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public string Parse(string s)
    {
        var operand1 = ParseOperand(s);
        var oper = string.Empty;
        var operand2 = string.Empty;
        s = s.Substring(operand1.Length).Trim();
        
        if (IsOperator(s))
        {
            oper = ParseOperator(s);
            s = s.Substring(1).Trim();
            operand2 = ParseOperand(s);
            s = s.Substring(operand2.Length).Trim();
        }

        if (!string.IsNullOrEmpty(s))
            throw new FormatException();

        return $"{operand1}{oper}{operand2}";
    }
    
    /// <summary>
    /// one of: + - * :
    /// </summary>
    /// <example>
    /// ParseOperator("+23") => "+"
    /// ParseOperator("-23") => "-"
    /// ParseOperator(":23") => ":"
    /// </example>
    private string ParseOperator(string s)
    {
        if (!IsOperator(s))
            throw new FormatException();
        
        return s[0].ToString();
    }

    private bool IsOperator(string s)
    {
        return s.Length > 0 && AllowedOperators.Contains(s[0]);
    }
    
    /// <summary>
    /// one of:
    /// int
    /// int . digits
    /// int / int
    /// Assume that s does not start with spaces
    /// </summary>
    /// <example>
    /// ParseOperand("37") => "37"
    /// ParseOperand("-2:3") => "-2"
    /// ParseOperand("-2/5") => "-2/5"
    /// ParseOperand("-2/5a") => "-2/5"
    /// ParseOperand("3.15abs") => "3.15"
    /// ParseOperand("a.15abs") => Exception
    /// </example>
    private string ParseOperand(string s)
    {
        var intPart = ParseInteger(s);
        var rest = s.Substring(intPart.Length);

        if (rest.Length == 0)
            return intPart;
        
        if (rest[0] == '.')
            return $"{intPart}{ParseDecimalSequence(rest)}";

        if (rest[0] == '/')
            return $"{intPart}/{ParseInteger(rest[1..])}";

        return intPart;
    }
    
    /// <summary>
    /// Parses an integer number. An integer number
    /// is an optional '-' followed by a sequence of digits
    /// Assume that s does not start with spaces
    /// </summary>
    /// <example>
    /// ParseInteger("1234a") => "1234"
    /// ParseInteger("-1234a") => "-1234"
    /// ParseInteger("1234.5678") => "1234"
    /// ParseInteger("-1234.5678") => "-1234"
    /// ParseInteger("-a.5678") => Exception
    /// ParseInteger("a123") => Exception
    /// </example>
    private string ParseInteger(string s)
    {
        if (!char.IsDigit(s[0]) && s[0] != '-')
            throw new FormatException();
        
        var isNegative = s[0] == '-';
        var digits = isNegative
            ? ParseDigitsSequence(s[1..])
            : ParseDigitsSequence(s);

        if (string.IsNullOrEmpty(digits))
            throw new FormatException();
        
        return isNegative
            ? $"-{digits}"
            : digits;
    }
    
    /// <summary>
    /// Parses a sequence of digits.
    /// Assume that s does not start with spaces
    /// </summary>
    /// <example>
    /// ParseDigitsSequence("a234") => ""
    /// ParseDigitsSequence("234") => "234"
    /// ParseDigitsSequence("234abc3345") => "234"
    /// </example>
    private string ParseDigitsSequence(string s)
    {
        int i = 0;
        while (i < s.Length)
        {
            if(!char.IsDigit(s[i]))
                break;
            i++;
        }

        return s.Substring(0, i);
    }

    /// <summary>
    /// Parses a decimal sequence.
    /// A decimal sequence is a decimal separator (.)
    /// followed by a sequence of digits
    /// Assume that s does not start with spaces
    /// </summary>
    /// <example>
    /// ParseDigitsSequence(".asd") => Exception
    /// ParseDigitsSequence(".234") => ".234"
    /// /// ParseDigitsSequence(".234a") => ".234"
    /// </example>
    private string ParseDecimalSequence(string s)
    {
        if (string.IsNullOrEmpty(s) || s[0] != '.')
            throw new FormatException();
        
        var digits = ParseDigitsSequence(s[1..]);
        if(string.IsNullOrEmpty(digits))
            throw new FormatException();
        
        return $".{digits}";
    }
    
    private Rational NumberToRational(string s)
    {
        var zeroesCount = s.Length - (s.IndexOf('.') + 1);
        var numerator = s.Replace(".", "");
        var denominator = "1".PadRight(zeroesCount + 1);

        return new Rational(
            int.Parse(numerator),
            int.Parse(denominator)
        );
    }
    private Rational FractionToRational(string s)
    {
        var parts = s.Split('/', StringSplitOptions.TrimEntries);
        return new Rational(
            int.Parse(parts[0]),
            int.Parse(parts[1])
        );
    }
}