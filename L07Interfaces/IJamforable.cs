namespace L07Interfaces;

public interface IJamforable<T>
{
    int JamforMed(T other);
}

public struct Integer : IJamforable<Integer>
{
    private int _n;

    public static implicit operator int(Integer n) => n._n;

    public static implicit operator Integer(int n)
    {
        Integer k = default;
        k._n = n;
        return k;
    }

    public int JamforMed(Integer other)
    {
        return _n.CompareTo(other._n);
    }

    public override string ToString() => _n.ToString();
}