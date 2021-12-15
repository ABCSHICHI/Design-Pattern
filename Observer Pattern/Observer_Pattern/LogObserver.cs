using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class LogObserver : ILoginSuccessObserver
    {

        private static LogService _logSrvice = new LogService();
        public void Process(LoginMessageModel message)
        {
            _logSrvice.PrintLof(message.UserId, message.LoginIP);
        }
    }
}
