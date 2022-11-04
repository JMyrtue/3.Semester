using System.Collections;

class Sequence : IEnumerable<int>

{
    int Start { get; set; }
    int Count { get; set; }
    int Skip { get; set; }

    public Sequence(int start, int count, int skip)
    {
        Start = start;
        Count = count;
        Skip = skip;
    }

    class SequenceEnumerator : IEnumerator<int>
    {
        int Count;
        int Skip;

        public SequenceEnumerator(int count, int skip, int start)
        {
            Count = count;
            Skip = skip;
            Current = start;
        }
        public int Current { get; set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            Current += Skip;
            if(Count > 0)
            {
                Count--;
                return true;
            }
            return false;
        }

        public void Reset()
        {
        }
    }
    List<int> list = new List<int>(); 
    public IEnumerator<int> GetEnumerator()
    {
        return new SequenceEnumerator(Count, Skip, Start);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}