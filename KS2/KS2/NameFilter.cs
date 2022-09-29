using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KS2
{
    public class NameFilter : PersonFilter
    {
        public string FilterName { get; set; }
        public override bool FilterPredicate(Person person)
        {
            if (person.Name == FilterName)
                return true;
            else
                return false;
        }
        public NameFilter(string filterName)
        {
            FilterName = filterName;
        }
    }
}
