using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Delegate_Pattern
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Client
    {
        BusinessDelegate businessDelegate;

        public Client(BusinessDelegate businessDelegate)
        {
            this.businessDelegate = businessDelegate;
        }

        public void Dotask()
        {
            businessDelegate.Dotask();
        }
    }
}
