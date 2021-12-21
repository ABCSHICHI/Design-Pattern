using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Locator_Pattern
{
    public class ServiceEntity_2 : Service
    {
        public void Execute()
        {
            Console.WriteLine("执行服务——2");
        }

        public string GetName()
        {
            return "Service_2";
        }
    }
}
