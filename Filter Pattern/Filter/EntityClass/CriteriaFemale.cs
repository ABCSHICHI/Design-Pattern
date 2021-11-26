using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern.Filter.EntityClass
{
    class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriterial(List<Person> person)
        {
            List<Person> femalePersons = new List<Person>();
            foreach (Person item in person)
            {
                if (item.GetGender().Equals("FEMALE"))
                {
                    femalePersons.Add(item);
                }
            }

            return femalePersons;
        }
    }
}
