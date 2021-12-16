using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern
{
    class NullCustomer : AbstractCustomer
    {
        public override string GetName()
        {
            return "Not available in Customer Database";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}
