using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Pattern.Filter
{
    interface ICriteria
    {
        List<Person> MeetCriterial(List<Person> person);
    }
}
