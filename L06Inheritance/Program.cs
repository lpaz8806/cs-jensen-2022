using L06Inheritance.Examples.Circuits;

class Program
{
    static void Main()
    {
        var circuit = new SerieCircuit(
            new ParallelCircuit(
                new Inductor(0.0002),
                new Capacitor(0.000001)
                ),
            new SerieCircuit(
                new Resistor(220),
                new Inductor(0.0003)
            )
        );
        
        Console.WriteLine(circuit.ComputeImpedance(50));
    }
}

