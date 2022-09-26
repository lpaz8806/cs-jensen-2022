using System.Collections;

namespace L07Interfaces.Examples;

public class EvenNumbers : IEnumerable<int>
{
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<int> GetEnumerator()
    {
        return new EvenNumbersEnumerator();
    }
}

public class EvenNumbersEnumerator :
    IEnumerator<int>
{
    private int _current = -2;
    
    public bool MoveNext()
    {
        _current += 2;
        return true;
    }

    public void Reset()
    {
        _current = -2;
    }

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public int Current
    {
        get
        {
            if (_current < 0)
                throw new InvalidOperationException("Call movenext first");
            
            return _current;
        }
    }
}