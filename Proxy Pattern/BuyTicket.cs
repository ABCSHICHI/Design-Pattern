using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class BuyTicket
    {
        static void Main(string[] args)
        {
            var proxy = new ProxySubject();
            proxy.GetTicket();

        }
    }
}
