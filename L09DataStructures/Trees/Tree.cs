namespace L09DataStructures.Trees;

public class Tree<T> : ITree<T>
{
    private ITree<T>[] _children;

    public Tree(T label, params ITree<T>[] children)
    {
        Label = label;
        _children = children;
    }
    public T Label { get; }
    public IEnumerable<ITree<T>> Children => _children;
}