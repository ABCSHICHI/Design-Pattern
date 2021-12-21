using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Locator_Pattern
{
    class ServiceLocator
    {
        private static Cache cache;
        private static bool isLoad = false;

        public static Service GetService(string jndiName)
        {
            if (!isLoad)
            {
                cache = new Cache();
                isLoad = true;
            }
            Service service = cache.GetService(jndiName);

            if (service !=null)
            {
                return service;
            }
            InitialContext context = new InitialContext();
            Service service1 = (Service)context.LookUp(jndiName);
            cache.AddService(service1);
            return service1;
        }

    }
}
