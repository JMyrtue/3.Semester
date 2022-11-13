class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>()
        {
            new Person() {Name = "Ib", Weight = 89.6, Age = 27},
            new Person() {Name = "Kaj", Weight = 65.7, Age = 17},
            new Person() {Name = "Ole", Weight = 77, Age = 7},
            new Person() {Name = "Anders", Weight = 72, Age = 40},
            new Person() {Name = "Børge", Weight = 88.8, Age = 13}
        };

        //opg1
        IEnumerable<Person> weightSortedPeople;
        weightSortedPeople = people.OrderBy(p => p.Weight);

        Console.WriteLine("People sorted by weight:");
        foreach (Person person in weightSortedPeople)
        {
            Console.WriteLine($"{person.Name} {person.Weight}kg");
        }
        Console.WriteLine();

        //opg2
        IEnumerable<Person> reverseNameSortedPeople;
        reverseNameSortedPeople = people.OrderByDescending(p => p.Name);

        Console.WriteLine("People sorted in reverse alphabetical order: ");
        foreach(Person p in reverseNameSortedPeople)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine();

        //opg3
        IEnumerable<Person> nameContainsAPeople;
        nameContainsAPeople = people.Where(p => p.Name.Contains('a') || p.Name.Contains('A'))
                                    .Where(p => p.Age > 10);

        Console.WriteLine("People older than 10 and with 'a' or 'A' in their name: ");
        foreach(Person person in nameContainsAPeople)
        {
            Console.WriteLine($"{person.Name} {person.Age}");
        }
        Console.WriteLine();

        //opg4 + opg5
        Person longestNamePerson = people.Max();
        Console.WriteLine("Person with the longest name:");
        Console.WriteLine(longestNamePerson.Name);
        Console.WriteLine();
        Console.WriteLine("Weight of the person with longest name: ");
        Console.WriteLine($"{longestNamePerson.Name} {longestNamePerson.Weight}kg");
    }
}
