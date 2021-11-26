using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern.Filter.EntityClass
{
    class AndCriteria : ICriteria
    {
        private ICriteria iCriteria;
        private ICriteria otherICriteria;

        public AndCriteria(ICriteria iCriteria, ICriteria otherICriteria)
        {
            this.iCriteria = iCriteria;
            this.otherICriteria = otherICriteria;
        }

        public List<Person> MeetCriterial(List<Person> person)
        {
            List<Person> firstCriteriaPerson = iCriteria.MeetCriterial(person);
            return otherICriteria.MeetCriterial(firstCriteriaPerson);
        }
    }
}
