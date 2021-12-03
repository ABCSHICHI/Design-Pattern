using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class RealSubject : ISubject
    {
        public void GetTicket()
        {
            Console.WriteLine(".....取票动作....");
        }
    }
}
