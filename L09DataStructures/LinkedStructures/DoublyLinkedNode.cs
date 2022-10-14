namespace L09DataStructures.LinkedStructures;

public class MyDoublyLinkedNode<T>
{
    public T Value { get; set; }
    public MyDoublyLinkedNode<T>? Next { get; set; }
    public MyDoublyLinkedNode<T>? Previous { get; set; }

    public MyDoublyLinkedNode(T value, MyDoublyLinkedNode<T>? next = null, MyDoublyLinkedNode<T>? prev = null)
    {
        Value = value;
        Next = next;
        Previous = prev;
    }
}