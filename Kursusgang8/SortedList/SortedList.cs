using System.Collections;

class SortedList<T> : ICollection<T> where T : IComparable
{
    List<T> list = new List<T>();
    public int Count => list.Count;

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T item)
    {
        list.Add(item);
        list.Sort();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public void GetElements()
    {
        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public void GetElementsReversed()
    {
        for(int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }
    }

    public void GetElementsBy(Predicate<T>) //Mangler implementation
    {
    } 

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    public bool Remove(T item)
    {
        if (list.Contains(item))
        {
            list.Remove(item);
            return true;
        }
        return false;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}