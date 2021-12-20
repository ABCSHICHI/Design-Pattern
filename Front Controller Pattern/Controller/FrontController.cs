using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_Controller_Pattern
{
    class FrontController
    {
        private Dispatcher dispatcher;
        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool isAuthenticUser()
        {
            Console.WriteLine("用户身份验证成功");
            return true;
        }

        private void TrackRequest(string request)
        {
            Console.WriteLine("窗口请求：" + request);
        }

        public void DispatchRequest(string request)
        {
            //记录每一个请求
            TrackRequest(request);

            //用户进行身份验证
            dispatcher.Dispatch(request);
        }
    }
}
