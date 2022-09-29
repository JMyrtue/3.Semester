using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFilter
{
    public abstract class PersonFilter
    {



        public abstract bool FilterPredicate(Person person)
        {

        }
    }
}
