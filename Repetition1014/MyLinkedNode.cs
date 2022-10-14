namespace Repetition1014;

public class MyLinkedNode<T>
{
    public T Value { get; }
    public MyLinkedNode<T>? Next { get; set; }

    public MyLinkedNode(T value, MyLinkedNode<T>? next = null)
    {
        Value = value;
        Next = next;
    }
}