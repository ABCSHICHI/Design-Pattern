using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class SmsObserver : ILoginSuccessObserver
    {
        private static SmsService _smsService= new SmsService();
        public void Process(LoginMessageModel message)
        {
            _smsService.SendMessage(message.UserName);
        }
    }
}
