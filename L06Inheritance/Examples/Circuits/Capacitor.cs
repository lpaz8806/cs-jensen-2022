namespace L06Inheritance.Examples.Circuits;

public class Capacitor : Circuit
{
    private double capacitance;

    public Capacitor(double capacitance)
    {
        this.capacitance = capacitance;
    }

    public override double ComputeImpedance(double frequency)
    {
        return 1 / (capacitance * frequency);
    }
}