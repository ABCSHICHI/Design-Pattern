using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class ProxySubject : ISubject
    {
        private static ISubject _subject = null;

        void ProxySubject_Init()
        {
            if(_subject == null)
            {
                _subject = new RealSubject();
            }
        }

        public void GetTicket()
        {
            if (_subject == null)
                ProxySubject_Init();
            _subject.GetTicket();
        }
    }
}
