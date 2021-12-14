using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    class USA : Country
    {
        public USA(UniteNations mediator) : base(mediator)
        {
        }

        //声明
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        //获取消息
        public void GetMessage(string message)
        {
            Console.WriteLine("美国获得对方消息：" + message);
        }
    }
}
