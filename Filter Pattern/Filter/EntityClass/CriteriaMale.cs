using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern.Filter.EntityClass
{
    class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriterial(List<Person> person)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person item in person)
            {
                if (item.GetGender().Equals("Male"))
                {
                    malePersons.Add(item);
                }
            }

            return malePersons;
        }
    }
}
