using System.Collections;
using L09DataStructures.LinkedStructures;

namespace L09DataStructures.Queue;

public class LinkedQueue<T> : IQueue<T>, IEnumerable<T>
{
    private MyLinkedNode<T> head;
    private MyLinkedNode<T> tail;


    public LinkedQueue()
    {
        tail = new MyLinkedNode<T>(default);
        head = new MyLinkedNode<T>(default, tail);
    }
    
    
    public void Enqueue(T item)
    {
        tail.Value = item;
        tail.Next = new MyLinkedNode<T>(default);
        tail = tail.Next;
    }

    public T Dequeue()
    {
        var front = Front;
        head = head.Next;
        return front;
    }

    public T Front => !IsEmpty ? head.Next.Value : throw new InvalidOperationException("Queue is empty");
    public bool IsEmpty => head.Next == tail;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<T> GetEnumerator()
    {
        for (var cursor = head.Next; cursor.Next != null; cursor = cursor.Next)
        {
            yield return cursor.Value;
        }
    }
}
