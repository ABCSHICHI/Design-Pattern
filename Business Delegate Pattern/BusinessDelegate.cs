using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Delegate_Pattern
{
    /// <summary>
    /// 业务代表
    /// </summary>
    class BusinessDelegate
    {
        private BusinessLookUp lookupService = new BusinessLookUp();
        private BusinessService businessService;
        private string serviceType;

        public void SetServiceType(string serviceType)
        {
            this.serviceType = serviceType;
        }

        public void Dotask()
        {
            businessService = lookupService.GetBusinessService(serviceType);
            businessService.DoProcessing();
        }
    }
}
