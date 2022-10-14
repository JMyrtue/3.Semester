// See https://aka.ms/new-console-template for more information

class HandyMethods<T>
    where T : IComparable<T>
{
    List<T> List;
    public HandyMethods(List<T> list)
    {
        List = list;
    }

    public T Min()
    {
        T min = List[0]; 
        foreach(T item in List)
        {
            if(item.CompareTo(min) < 0)
                min = item;
        }
        return min;
    }

    public T Max()
    {
        T max = List[0];
        foreach (T item in List)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }

    public T[] CopyArray(T[] arr1, T[] arr2)
    {
        if (arr1.Length != arr2.Length)
            throw new Exception();
            arr1 = arr2;
        return arr1;
    }

    public T[] Shuffle(T[] arr)
    {
        Random rand = new Random();
        for(int i = 0; i < arr.Length; i++)
        {
            int index1 = rand.Next(arr.Length);
            int index2 = rand.Next(arr.Length);
            (arr[index1],arr[index2]) = (arr[index2],arr[index1]);
        }
        
        return arr;
    }
}