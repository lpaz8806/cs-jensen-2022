namespace Repetition1005;

public class ParserResult
{
    public Rational Operand1 { get; }
    public Rational Operand2 { get; }
    public string Operator { get; }

    public ParserResult(Rational operand1, Rational operand2, string op)
    {
        Operand1 = operand1;
        Operand2 = operand2;
        Operator = op;
    }
}