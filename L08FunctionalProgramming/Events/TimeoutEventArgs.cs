namespace L08FunctionProgramming.Events;

public class TimeoutEventArgs : EventArgs
{
    public int TickCount
    {
        get;
        private set;
    }

    public TimeoutEventArgs(int tickCount)
    {
        TickCount = tickCount;
    }
}