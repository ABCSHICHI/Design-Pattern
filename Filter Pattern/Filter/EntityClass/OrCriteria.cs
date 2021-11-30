using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern.Filter.EntityClass
{
    class OrCriteria : ICriteria
    {
        private ICriteria iCriteria;
        private ICriteria otherICriteria;

        public OrCriteria(ICriteria iCriteria, ICriteria otherICriteria)
        {
            this.iCriteria = iCriteria;
            this.otherICriteria = otherICriteria;
        }

        public List<Person> MeetCriterial(List<Person> person)
        {
            List<Person> firstICriteriaItems = iCriteria.MeetCriterial(person);
            List<Person> otherICriteriaItems = otherICriteria.MeetCriterial(person);

            foreach (Person item in otherICriteriaItems)
            {
                firstICriteriaItems.Add(item);
            }
            return firstICriteriaItems;
        }
    }
}
