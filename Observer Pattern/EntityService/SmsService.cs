using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class SmsService
    {

        public void SendMessage(string message) => Console.WriteLine("欢迎登录：" + message);
    }
}
