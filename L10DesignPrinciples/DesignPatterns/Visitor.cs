namespace L10DesignPrinciples.DesignPatterns;

public class Visitor
{
    public static void Run(IExpression e)
    {
        e.Accept(new Eval());
    }
}

public interface IExpressionVisitor
{
    void Visit(Number n);
    void Visit(Add ex);
}

public interface IExpression
{
    void Accept(IExpressionVisitor visitor);
}

public class Eval : IExpressionVisitor
{
    private double result;
    
    public void Visit(Number n)
    {
        result = n.Value;
    }

    public void Visit(Add ex)
    {
        throw new NotImplementedException();
    }
}

public class Number : IExpression
{
    public double Value { get; }

    public void Accept(IExpressionVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Add : IExpression
{
    public IExpression Left { get; }
    public IExpression Right { get; }
    
    public void Accept(IExpressionVisitor visitor)
    {
        visitor.Visit(this);
    }
}