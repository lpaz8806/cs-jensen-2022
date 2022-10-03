namespace L08FunctionProgramming.Events;

public class PrettyGirl : IStalkable
{
    public void Check()
    {
        var distanceToCreepyGuy = 0.5;
        if (distanceToCreepyGuy < 1)
        {
            // Scream!
            
            OnStalkingAlert();
        }
    }
    
    public event EventHandler? StalkingAlert;

    protected void OnStalkingAlert()
    {
        if (StalkingAlert != null)
        {
            StalkingAlert(this, EventArgs.Empty);
        }
    }
}