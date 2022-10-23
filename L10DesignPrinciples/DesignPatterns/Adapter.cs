namespace L10DesignPrinciples.DesignPatterns;

public class AdapterPattern
{
    public static void Run()
    {
        var stack = new Stack<int>();
        
        Foo(new StackAdapter<int>(stack));
    }
    
    static void Foo(IStack<int> foo)
    {
        
    }
}

public interface IStack<T>
{
    void Push(T item);
    T Pop();
    T Top { get; }
    bool IsEmpty { get; }
}

class StackAdapter<T> : IStack<T>
{
    private readonly Stack<T> _dotnetStack;

    public StackAdapter(Stack<T> dotnetStack)
    {
        _dotnetStack = dotnetStack;
    }
    
    public void Push(T item)
    {
        _dotnetStack.Push(item);
    }

    public T Pop()
    {
        return _dotnetStack.Pop();
    }

    public T Top => _dotnetStack.Peek();
    public bool IsEmpty => _dotnetStack.Count == 0;
}
