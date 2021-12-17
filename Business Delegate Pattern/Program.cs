using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Delegate_Pattern
{
    /// <summary>
    /// 业务代表模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.SetServiceType("EJB");
            Client client = new Client(businessDelegate);
            client.Dotask();

            businessDelegate.SetServiceType("JMS");
            client.Dotask();
        }
    }
}
