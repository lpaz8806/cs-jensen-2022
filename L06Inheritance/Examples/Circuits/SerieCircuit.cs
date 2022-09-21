namespace L06Inheritance.Examples.Circuits;

public class SerieCircuit : CompoundCircuit
{
    public SerieCircuit(Circuit c1, Circuit c2)
        : base(c1, c2)
    {
    }

    public override double ComputeImpedance(double frequency)
    {
        return 
            C1.ComputeImpedance(frequency) +
            C2.ComputeImpedance(frequency);
    }
}