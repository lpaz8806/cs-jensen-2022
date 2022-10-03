namespace L08FunctionProgramming.Events;

public class Emitter
{
    private bool isRunning = false;
    private Thread th;
    private int timeoutInMs;
    
    public Emitter(int timeoutInMs)
    {
        this.timeoutInMs = timeoutInMs;
    }

    public void Start()
    {
        isRunning = true;
        var th = new Thread(Loop);
        th.Start();
    }
    
    public void Stop()
    {
        isRunning = false;
        th = null;
    }

    private void Loop()
    {
        while (true)
        {
            Thread.Sleep(timeoutInMs);
            var tc = Environment.TickCount;
            Timeout(this, new TimeoutEventArgs(tc));
        }
    }
    
    public event EventHandler<TimeoutEventArgs> Timeout;
    
}