namespace Repetition1014;

public class Vertex<T>
{
    public T Value { get; }
    public List<Vertex<T>> Edges { get; }

    public Vertex(T value, params Vertex<T>[] edges)
    {
        Value = value;
        Edges = new List<Vertex<T>>(edges);
    }

    public override string ToString()
    {
        return $"{Value} ({GetHashCode()})";
    }
}
