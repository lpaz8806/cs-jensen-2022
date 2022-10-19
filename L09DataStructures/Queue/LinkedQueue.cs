using System.Collections;
using L09DataStructures.LinkedStructures;

namespace L09DataStructures.Queue;

public class LinkedQueue<T> : IQueue<T>, IEnumerable<T>
{
    private MyLinkedNode<T> first;
    private MyLinkedNode<T> last;


    public LinkedQueue()
    {
        last = new MyLinkedNode<T>(default);
        first = new MyLinkedNode<T>(default, last);
    }
    
    
    public void Enqueue(T item)
    {
        last.Value = item;
        last.Next = new MyLinkedNode<T>(default);
        last = last.Next;
    }

    public T Dequeue()
    {
        var front = Front;
        first = first.Next;
        return front;
    }

    public T Front => !IsEmpty ? first.Next.Value : throw new InvalidOperationException("Queue is empty");
    public bool IsEmpty => first.Next == last;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<T> GetEnumerator()
    {
        for (var cursor = first.Next; cursor.Next != null; cursor = cursor.Next)
        {
            yield return cursor.Value;
        }
    }
}
