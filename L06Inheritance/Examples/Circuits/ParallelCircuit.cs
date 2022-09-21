namespace L06Inheritance.Examples.Circuits;

public class ParallelCircuit : CompoundCircuit
{
    public ParallelCircuit(Circuit c1, Circuit c2)
        : base(c1, c2)
    {
    }

    public override double ComputeImpedance(double frequency)
    {
        var c1Z = C1.ComputeImpedance(frequency);
        var c2Z = C2.ComputeImpedance(frequency);
        return (c1Z * c2Z) / (c1Z + c2Z) ;
    }
}