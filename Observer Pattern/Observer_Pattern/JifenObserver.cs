using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class JifenObserver : ILoginSuccessObserver
    {
        public static JifenService _jifenService = new JifenService();
        public void Process(LoginMessageModel message)
        {
            _jifenService.AddJifen(message.UserName, 5);
        }
    }
}
