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
