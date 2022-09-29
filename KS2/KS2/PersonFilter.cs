using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class PersonFilter
{
    public abstract bool FilterPredicate(Person person);

    public virtual List<Person> Filter(List<Person> people)
    {
        List<Person> result = new List<Person>();
        foreach (Person person in people)
        {
            if(FilterPredicate(person))
                result.Add(person);
        }
        return result;
    }
}

