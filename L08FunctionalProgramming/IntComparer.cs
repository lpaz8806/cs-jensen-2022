namespace L08FunctionProgramming;

public class IntComparer : IComparer<int>
{
    public int Compare(int x, int y) => x.CompareTo(y);
}