using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Random r = new Random();
        int randomNum = 0;
        int outerVar = 7;
        for(int i = 1; i < 20; i++)
        {
            randomNum = r.Next(0, 100);
            numbers.Add(randomNum);
        }

        //Opg 1
        IEnumerable<int> outerVarNumbers;
        outerVarNumbers = numbers.Where(x => x % outerVar == 0);

        Console.WriteLine("Numbers dividable by 7:");
        foreach (int i in outerVarNumbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //Opg 2
        int min = 20;
        int max = 40;
        IEnumerable<int> minMaxNumbers;
        minMaxNumbers = numbers.Where(x => x >= min && x <= max);

        Console.WriteLine("Numbers between 20 and 40:");
        foreach(int i in minMaxNumbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //opg 3
        int highestNumber = numbers.Where(x => x >= min && x <= max).Max();

        Console.WriteLine("Highest number between 20 and 40:");
        Console.WriteLine(highestNumber);
        Console.WriteLine();

        //opg 4
        int smallerOuterValue = 2;
        IEnumerable<int> doubledNumbers;
        doubledNumbers = numbers.Select(x => x * smallerOuterValue);

        Console.WriteLine("Doubled numbers:");
        foreach(var i in doubledNumbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //opg 5
        IEnumerable<int> descendedSortedNumbers;
        descendedSortedNumbers = numbers.OrderByDescending(x => x);

        Console.WriteLine("Numbers sorted in descending order:");
        foreach (var i in descendedSortedNumbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //opg 6
        IEnumerable<int> combinedCriteriaList;
        combinedCriteriaList = numbers.Where(x => x >= min && x <= max)
                                      .Select(x => x * smallerOuterValue)
                                      .OrderByDescending(x => x);

        Console.WriteLine("Multiple Criteria; Doubled numbers between 20 and 40, descendant sorted: ");
        foreach(int i in combinedCriteriaList)
        {
            Console.WriteLine(i);
        }

    }
}