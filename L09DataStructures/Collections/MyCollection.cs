using System.Collections;
using NotImplementedException = System.NotImplementedException;

namespace L09DataStructures.Collections;

public class MyCollection<T> : ICollection<T>
{
    protected T[] _items;
    protected int _count = 0;

    public MyCollection(int capacity = 10)
    {
        _items = new T[capacity];
    }
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < _count; i++)
            yield return _items[i];
    }

    public void Add(T item)
    {
        if (Count == Capacity)
            Resize();
        
        _items[_count] = item;
        _count++;
    }

    private void Resize()
    {
        Array.Resize(ref _items, Capacity + 1);
    }
    
    public void Clear()
    {
        _count = 0;
    }

    public bool Contains(T item)
    {
        return this.Any(x => Equals(x, item));
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        var i = IndexOf(item);
        if (i == -1)
            return false;
        
        for (int j = i + 1; j < Count; j++)
            _items[j - 1] = _items[j];
        
        _count--;
        return true;
    }

    protected int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
            if (Equals(item, _items[i]))
                return i;
        return -1;
    }
    
    public int Capacity => _items.Length;
    public int Count => _count;
    public bool IsReadOnly => false;
}