class MyQueue<T>
{
    private List<T> _list = new List<T>();

    public void Enqueue(T item)
    {
        _list.Add(item);
    }

    public T Dequeue()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("Очередь пуста.");

        T item = _list[0];
        _list.RemoveAt(0);

        return item;
    }

    public T Peek()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("Очередь пуста.");

        return _list[0];
    }

    public int Count
    {
        get { return _list.Count; }
    }

    public void Clear()
    {
        _list.Clear();
    }
}