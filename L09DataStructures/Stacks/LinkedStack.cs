using L09DataStructures.LinkedStructures;

namespace L09DataStructures.Stacks;

public class LinkedStack<T> : IStack<T>
{
    private MyLinkedNode<T>? _head;
    public void Push(T item)
    {
        var newTop = new MyLinkedNode<T>(item);
        newTop.Next = _head;
        _head = newTop;
    }

    public T Pop()
    {
        var top = Top;
        _head = _head!.Next;
        return top;
    }

    public T Top => !IsEmpty ? _head!.Value : throw new InvalidOperationException("Stack is empty");
    public bool IsEmpty => _head == null;
}
