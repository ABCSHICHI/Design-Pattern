using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Locator_Pattern
{
    /// <summary>
    /// 带有对要查找的服务的引用
    /// </summary>
    class InitialContext
    {
        public Object LookUp(string jndiName)
        {
            if (jndiName.Equals("SERVICE_1"))
            {
                Console.WriteLine("查找并创建新的服务SERVICE_1对象");
                return new ServiceEntity_1();
            }
            else if(jndiName.Equals("SERVICE_2"))
            {
                Console.WriteLine("查找并创建新的服务SERVICE_2对象");
                return new ServiceEntity_2();
            }
            return null;
        }
    }
}
