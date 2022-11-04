using System.Collections;

class Program
{
    static void Main()
    {
        SortedList<int> intList = new SortedList<int>();
        SortedList<string> stringList = new SortedList<string>();

        intList.Add(1);
        intList.Add(4);
        intList.Add(2);
        intList.Add(7);
        intList.Add(0);
        intList.Add(10);
        intList.Add(3);

        intList.GetElements();
        Console.WriteLine();
        intList.GetElementsReversed();

        stringList.Add("en");
        stringList.Add("to");
        stringList.Add("tre");
        stringList.Add("fire");
        stringList.Add("fem");
        stringList.Add("seks");
        stringList.Add("syv");

        foreach (var item in stringList)
        {
            Console.WriteLine(item);
        }


    }
}

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

    public void GetElementsBy(Predicate<T>)
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