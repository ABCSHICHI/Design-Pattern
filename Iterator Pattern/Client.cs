using Iterator_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Client
    {
        static void Main()
        {
            ConcreteAggregate monkey = new ConcreteAggregate();
            monkey[0] = "猴子";
            monkey[1] = "刘木同";
            monkey[2] = "笨蛋";
            monkey[3] = "小弟";
            monkey[4] = "领导";
            monkey[5] = "内部人员";
            monkey[6] = "小偷";

            Iterator i = new ConcreteIterator(monkey);
            object item = i.First();//从第一个乘客开始
            while (!i.IsDone())
            {
                Console.WriteLine("{0}请买火车票", i.CurrentItem());//若没买票，请补票
                i.Next();//遍历下一个
            }
        }
    }
}
