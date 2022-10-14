// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Pair<string, bool> par = new Pair<string, bool>("Fuckoff", true);
        Console.WriteLine(par.Value1 + " " + par.Value2);
        //var nytPar = par.Swap();
        //Console.WriteLine(nytPar.Value1 + nytPar.Value2);
        var nytPar = par.SetFst(5);

        Console.WriteLine($"{nytPar.Value1} {nytPar.Value2}");

    }
}

class Pair<T1, T2> 
{
    public T1 Value1 { get; }
    public T2 Value2 { get; }
    public Pair(T1 value1, T2 value2)
    {
        Value1 = value1;
        Value2 = value2;
    }

    public Pair<T2, T1> Swap()
    {
        return new Pair<T2, T1>(Value2, Value1);
    }

    public Pair<C, T2> SetFst<C>(C c)
    {
        return new Pair<C, T2>(c, Value2);
    }

    public Pair<T1, C> SetSnd<C>(C c)
    {
        return new Pair<T1, C>(Value1, c);
    }

}
