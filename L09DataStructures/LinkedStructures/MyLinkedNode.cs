namespace L09DataStructures.LinkedStructures;

public class MyLinkedNode<T>
{
    public T Value { get; set; }
    public MyLinkedNode<T>? Next { get; set; }

    public MyLinkedNode(T value, MyLinkedNode<T>? next = null)
    {
        Value = value;
        Next = next;
    }
}