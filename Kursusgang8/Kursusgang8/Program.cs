class Program
{
    static void Main()
    {
        Sequence ints = new Sequence(1, 3, 7);

        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }
    }
}
