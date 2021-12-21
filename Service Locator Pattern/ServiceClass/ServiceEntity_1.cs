using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Locator_Pattern
{
    public class ServiceEntity_1 : Service
    {
        public void Execute()
        {
            Console.WriteLine("执行服务——1");
        }

        public string GetName()
        {
            return "Service_1";
        }
    }
}
