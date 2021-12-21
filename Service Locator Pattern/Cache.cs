using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Locator_Pattern
{
    /// <summary>
    /// 缓存存储服务的引用， 以便服用它们
    /// </summary>
    class Cache
    {
        private List<Service> services;

        public Cache()
        {
            services = new List<Service>();
        }

        public Service GetService(string serviceName)
        {
            foreach (var item in services)
            {
                if (item.GetName().Equals(serviceName))
                {
                    Console.WriteLine("返回缓存：" + serviceName + " 对象");
                    return item;

                }
            }
            return null;
        }

        public void AddService(Service newService)
        {
            bool exists = false;
            foreach (var item in services)
            {
                if (item.GetName().Equals(newService.GetName()))
                {
                    exists = true;
                }
            }
            if (!exists)
                services.Add(newService);
        }
    }
}
