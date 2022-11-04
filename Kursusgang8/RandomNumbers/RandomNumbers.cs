using System.Collections;

class RandomNumbers : IEnumerable<int>
{
    int Seed { get; set; }
    int Min { get; set; }
    int Max { get; set; }

    public RandomNumbers(int seed, int min, int max)
    {
        Seed = seed; 
        Min = min; 
        Max = max; 
    }

    class RandomEnumerator : IEnumerator<int>
    {
        int Min { get; set; }
        int Max { get; set; }
        Random Random;
        public RandomEnumerator(int seed, int min, int max)
        {
            Min = min;
            Max = max;
            Random = new Random(seed);
        }

        public int Current { get; set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            Current = Random.Next(Min, Max);
            return true;
        }

        public void Reset()
        {
        }
    }
    public IEnumerator<int> GetEnumerator()
    {
        return new RandomEnumerator(Seed, Min, Max);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}