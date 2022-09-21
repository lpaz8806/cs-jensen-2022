namespace L06Inheritance.Examples.Circuits;

public class Resistor : Circuit
{
    private double resistance;

    public Resistor(double resistance)
    {
        this.resistance = resistance;
    }

    public override double ComputeImpedance(double frequency)
    {
        return resistance;
    }
}