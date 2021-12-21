using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Locator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = ServiceLocator.GetService("SERVICE_1");
            service.Execute();

            service = ServiceLocator.GetService("SERVICE_2");
            service.Execute();

            service = ServiceLocator.GetService("SERVICE_1");
            service.Execute();

            service = ServiceLocator.GetService("SERVICE_2");
            service.Execute();
        }
    }
}
