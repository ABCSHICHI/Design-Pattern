using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern
{
    class CustomerFactory
    {
        public static string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer GetCustomer(string name)
        {
            foreach (var item in names)
            {
                if (item.Equals(name))
                    return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }
}
