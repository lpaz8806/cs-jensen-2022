namespace L09DataStructures.Queue;

public interface IQueue<T>
{
    void Enqueue(T item);
    T Dequeue();
    T Front { get; }
    bool IsEmpty { get; }
}