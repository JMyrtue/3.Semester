// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        HandyMethods<int> list = new HandyMethods<int>(intList);

        //Console.WriteLine(intList.Max());
        //Console.WriteLine(intList.Min());

        HandyMethods<string> stringList = new HandyMethods<string>(new List<string> { "hej", "farvel", "fuckoff" });

        //Console.WriteLine(stringList.Max());
        //Console.WriteLine(stringList.Min());

        int[] talList = new int[] {1, 2, 3 };
        int[] talList2 = new int[] { 4, 5, 6 };

        //Console.WriteLine(talList.Max());
        //Console.WriteLine(talList.Min());

        //Console.WriteLine(list.CopyArray(talList, talList2).Max());
        //Console.WriteLine(list.CopyArray(talList, talList2).Min());

        int[] shuffleList = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        foreach (int item in shuffleList)
        {
            Console.WriteLine(item);
        }

        list.Shuffle(shuffleList);
        Console.WriteLine("");

        foreach(int item in shuffleList)
        {
            Console.WriteLine(item);
        }

    }
}
