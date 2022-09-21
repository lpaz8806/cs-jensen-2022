namespace L06Inheritance.Examples.Circuits;

public class Inductor : Circuit
{
    private double inductance;

    public Inductor(double inductance)
    {
        this.inductance = inductance;
    }
    
    public override double ComputeImpedance(double frequency)
    {
        return frequency * inductance;
    }
}
