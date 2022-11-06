public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        if (this.Name.Length > other.Name.Length)
            return 1;
        return 0;
    }
}