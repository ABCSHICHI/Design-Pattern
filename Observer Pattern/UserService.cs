using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public delegate void LoginSuccessDelegate(LoginMessageModel message);

    class UserService
    {
        public static event LoginSuccessDelegate loginSuccessEvent;

        public static void Main1()
        {
            loginSuccessEvent += new SmsObserver().Process;
            loginSuccessEvent += new JifenObserver().Process;
            loginSuccessEvent += new LogObserver().Process;

            var message = new LoginMessageModel
            {
                UserName = "七魄尸狗",
                UserId = "876938445",
                LoginIP = "127.0.1.3"
            };

            loginSuccessEvent?.Invoke(message);
        }

        #region 增加、删除订阅者
        static void Subscriber()
        {
            AddLoginObserver(new SmsObserver());
            AddLoginObserver(new JifenObserver());
            AddLoginObserver(new LogObserver());


            var message = new LoginMessageModel
            {
                UserName = "七魄尸狗",
                UserId = "876938445",
                LoginIP = "127.0.1.3"
            };
            foreach (var observer in loginSuccessObservers)
            {
                observer.Process(message);
            }
        }
        private static List<ILoginSuccessObserver> loginSuccessObservers = new List<ILoginSuccessObserver>();

        public static void AddLoginObserver(ILoginSuccessObserver observer)
        {
            loginSuccessObservers.Add(observer);
        }
        public static void RemoveLoginObserver(ILoginSuccessObserver observer)
        {
            loginSuccessObservers.Remove(observer);
        }
        #endregion

        #region 常规操作
        private static SmsService _smsService = new SmsService();
        private static JifenService _jifenService = new JifenService();
        private static LogService _logService = new LogService();

        static void CommProce()
        {
            _smsService.SendMessage("欢迎登录");
            _jifenService.AddJifen(" ",5);
            _logService.PrintLof(" ", "记录登录IP");
        }
        #endregion

        

    }
}
