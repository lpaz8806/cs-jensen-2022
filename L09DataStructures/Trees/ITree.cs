namespace L09DataStructures.Trees;

public interface ITree<T>
{
    T Label { get; }
    IEnumerable<ITree<T>> Children { get; }
}