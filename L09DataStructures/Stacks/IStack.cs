namespace L09DataStructures.Stacks;

public interface IStack<T>
{
    void Push(T item);
    T Pop();
    T Top { get; }
    bool IsEmpty { get; }
}