namespace Repetition1014;

public class Counter
{
    private int count;

    public Counter(int count = 0)
    {
        this.count = count;
    }
    
    
    public int Count => count;
    
    public void Inc() => count++;
}

