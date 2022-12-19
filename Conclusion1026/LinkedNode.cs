using System.Collections;

namespace Conclusion1026;

public class LinkedNode
{
    public int Value { get; set; }
    public LinkedNode? Next { get; set; }

    public LinkedNode(int value, LinkedNode? next = null)
    {
        Value = value;
        Next = next;
    }
    
    public static IEnumerable<int> Enumerate(LinkedNode? n)
    {
        while (n != null)
        {
            yield return n.Value;
            n = n.Next;
        }
    }
    
    public IEnumerable<int> EnumerateMe()
    {
        var n = this;
        while (n != null)
        {
            yield return n.Value;
            n = n.Next;
        }
    }

    public static LinkedNode Create(params int[] items)
    {
        if (items.Length == 0) return null;
        LinkedNode list = new LinkedNode(items[0]);
        var cursor = list;

        for (int i = 1; i < items.Length; i++)
        {
            cursor.Next = new LinkedNode(items[i]);
            cursor = cursor.Next;
        }

        return list;
    }

    public static bool IsPalindrome(LinkedNode n)
    {
        var stack = new Stack<int>();
        foreach (var item in Enumerate(n))
            stack.Push(item);

        foreach (var item in Enumerate(n))
            if (item != stack.Pop())
                return false;

        return true;
    }

    public bool ArPalindrome()
    {
        var stack = new Stack<int>();
        foreach (var item in Enumerate(this))
            stack.Push(item);

        foreach (var item in Enumerate(this))
            if (item != stack.Pop())
                return false;

        return true;
    }
}
