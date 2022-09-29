using KS2;
using System;

public class program
{
    static void Main()
    {
        //Employee Krath = new Employee("Andreas Krath", "Usling", 10);
        //Manager Jonathan = new Manager("Fucking Jonathan", "Pisker af Krath", 50000, 50000);

        //Jonathan.IncreaseSeniority();
        //Console.WriteLine(Jonathan.SeniorityLevel);
        //Console.WriteLine(Jonathan.Salary);

        //Console.WriteLine(Krath.CalculateYearlySalary());

        //        1 //With a Person-list:
        //2 List<Person> plist = new List<Person>();
        //        3 plist.Add(new Person("Thomas", ...));
        //        4 plist.Add(new Person("Erik", ...));
        //        5 plist.Add(new Employee("Bo", ...));
        //        6 plist.Add(new Employee("Hans", ...));
        //        7 plist.Add(new Person("Kurt", ...));
        //         //I can retrieve a list of all named ''Thomas'' using:
        //         PersonFilter pfilter = new NameFilter("Thomas");
        //         List<Person> filteredList = pfilter.Filter(plist);

        List<Person> plist = new List<Person>();
        plist.Add(new Employee("Thosmas", "Vicevært", 24000));
        plist.Add(new Employee("Erik", "Kontormand", 32000));

        PersonFilter nameFilter = new NameFilter("Thomas");

        foreach(var i in plist)
        {
            List<Person> filteredList = nameFilter.FilterPredicate(i);

        }
        foreach (var member in filteredList)
        {
            Console.WriteLine(member);
        }
    }
}
