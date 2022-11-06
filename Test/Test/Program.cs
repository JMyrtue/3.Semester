using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int mini = int.Parse(Console.ReadLine());
        int maxi= int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());


        IEnumerable<int> minIntList = mini.ToString().Select(min => int.Parse(min.ToString()));

        while (minIntList.Sum() != sum)
        {
            mini++;
            minIntList = mini.ToString().Select(min => int.Parse(min.ToString()));
        }

        IEnumerable<int> maxIntList = maxi.ToString().Select(max => int.Parse(max.ToString()));

        while (maxIntList.Sum() != sum)
        {
            maxi--;
            maxIntList = maxi.ToString().Select(max => int.Parse(max.ToString()));
        }

        Console.WriteLine(mini);
        Console.WriteLine(maxi);

    }
}