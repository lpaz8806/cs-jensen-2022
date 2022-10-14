using System.Collections;

namespace Repetition1014;

public class MyRange : IEnumerable<int>
{
    private int start, end;

    public MyRange(int start, int end = int.MaxValue)
    {
        this.start = start;
        this.end = end;
    }
    
    
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = start; i <= end; i++)
            yield return i;
    }

    public IEnumerable<int> EvenNumbers()
    {
        foreach (var number in this)
            if (number % 2 == 0)
                yield return number;
    }
}
