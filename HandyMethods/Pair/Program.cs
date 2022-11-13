// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        //Pair<string, bool> par = new Pair<string, bool>("Fuckoff", true);
        //Console.WriteLine(par.Value1 + " " + par.Value2);
        ////var nytPar = par.Swap();
        ////Console.WriteLine(nytPar.Value1 + nytPar.Value2);
        //var nytPar = par.SetFst(5);

        //Console.WriteLine($"{nytPar.Value1} {nytPar.Value2}");

        var Dicktionary = new Dict<K,V>();
    }
}

class Dict<K,V>
{
    List<Pair<K,V>> Dicktionary = new List<Pair<K,V>>();

    public Dict()
    {

    }
    public V Get(K key)
    {
        foreach(Pair<K,V> pair in Dicktionary)
        {
            if (pair.Value1.Equals(key))
                return pair.Value2;
        }
        throw new ArgumentException("Key not present in the Dictionary");
    }

    public void Put(K key, V value)
    {
        foreach(Pair<K,V> pair in Dicktionary)
        {
            if (pair.Value1.Equals(key))
                Dicktionary.Remove(pair);
        }
        Dicktionary.Add(new Pair<K,V>(key, value));
    }
}