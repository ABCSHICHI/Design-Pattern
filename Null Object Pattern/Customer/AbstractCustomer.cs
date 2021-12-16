using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern
{
    public abstract class AbstractCustomer
    {
        protected string name;
        public abstract bool IsNull();
        public abstract string GetName();
    }
}
