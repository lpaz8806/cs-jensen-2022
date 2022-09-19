namespace L05Classes;

public class MyStopwatch
{
    private bool isRunning = false;
    private long startTime = 0;
    private long endTime = 0;

    public bool IsRunning
    {
        get { return isRunning; }
    }

    public long ElapsedMilliseconds
    {
        get
        {
            if (IsRunning)
                return Environment.TickCount - startTime;
            
            return endTime - startTime;
        }
    }
    
    public void Start()
    {
        startTime = Environment.TickCount;
        isRunning = true;
    }
    public void Stop()
    {
        if (isRunning)
        {
            endTime = Environment.TickCount64;
            isRunning = false;
        }
    }
}