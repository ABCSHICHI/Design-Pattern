using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern.Filter.EntityClass
{
    class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriterial(List<Person> person)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (Person item in person)
            {
                if (item.GetGender().Equals("SINGLE"))
                {
                    singlePersons.Add(item);
                }
            }

            return singlePersons;
        }
    }
}
