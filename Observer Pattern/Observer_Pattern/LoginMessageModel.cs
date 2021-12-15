using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class LoginMessageModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        private string userName;
        public string UserName { get => userName; set => userName = value; }

        /// <summary>
        /// 用户id
        /// </summary>
        private string userId;
        public string UserId { get => userId; set => userId = value; }

        /// <summary>
        /// 日志id
        /// </summary>
        private string loginIP;
        public string LoginIP { get => loginIP; set => loginIP = value; }
    }
}
