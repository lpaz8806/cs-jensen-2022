namespace Conclusion1024;

public interface ISerializer<T>
{
    string Serialize(T obj);
    T Deserialize(string serialization);
}

class MyModel
{
    
}

class Foo
{
    public Foo(ISerializer<MyModel> serializer)
    {
        
    }
}

// -----

class JsonSerializer<T> : ISerializer<T>
{
    public string Serialize(T obj)
    {
        throw new NotImplementedException();
    }

    public T Deserialize(string serialization)
    {
        throw new NotImplementedException();
    }
}