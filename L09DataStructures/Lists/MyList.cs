using System.Collections;
using L09DataStructures.Collections;

namespace L09DataStructures.Lists;

public class MyList<T> : MyCollection<T>, IList<T>
{
    public T this[int index]
    {
        get
        {
            CheckBoundaries(index);
            return _items[index];
        }
        set
        {
            CheckBoundaries(index);
            _items[index] = value;
        }
    }
    
    public new int IndexOf(T item)
    {
        return base.IndexOf(item);
    }

    public void Insert(int index, T item)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
    
    private void CheckBoundaries(int index)
    {
        if (index >= Count)
            throw new IndexOutOfRangeException();
    }
}