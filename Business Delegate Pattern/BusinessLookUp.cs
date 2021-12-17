using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Delegate_Pattern
{
    /// <summary>
    /// 业务查询服务
    /// </summary>
    class BusinessLookUp
    {
        public BusinessService GetBusinessService(string serviceType)
        {
            if (serviceType.Equals("EJB"))
            {
                return new EJBService();
            }
            else
            {
                return new JMSService();
            }
        }
    }
}
