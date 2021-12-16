using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
