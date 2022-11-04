using System.Collections;

class Program
{
    static void Main()
    {

        RandomNNumbers blandettal = new RandomNNumbers(5, 1, 101, 10);

        foreach (int i in blandettal)
        {
            Console.WriteLine(i);
        }
    }
}

class RandomNNumbers : IEnumerable<int>
{
    int Seed { get; set; }
    int Min { get; set; }
    int Max { get; set; }
    int Count { get; set; }

    public RandomNNumbers(int seed, int min, int max, int count)
    {
        Seed = seed; 
        Min = min; 
        Max = max; 
        Count = count;
    }

    class RandomNEnumerator : IEnumerator<int>
    {
        int Min { get; set; }
        int Max { get; set; }
        int Count{ get; set; }
        Random Random;
        public RandomNEnumerator(int seed, int min, int max, int count)
        {
            Min = min;
            Max = max;
            Random = new Random(seed);
            Count = count;
        }

        public int Current { get; set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(Count > 0)
            {
                Count--;
                Current = Random.Next(Min, Max);
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
        }
    }
    public IEnumerator<int> GetEnumerator()
    {
        return new RandomNEnumerator(Seed, Min, Max, Count);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}