using Flyweight_Pattern.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    /// <summary>
    /// 客户端
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            //定义外部状态，例如字母的位置等信息
            int extrinsicstate = 10;
            //初始化享元工厂
            var factory = new FlyweightFactory();

            // 判断是否已经创建了字母A，如果已经创建就直接使用创建的对象A
            AbstractFlyweight fa = factory.GetFlyweight("A");
            if (fa != null)
                //把外部状态作为享元对象的方法调用
                fa.Operation(--extrinsicstate);

            // 判断是否已经创建了字母B
            AbstractFlyweight fb = factory.GetFlyweight("B");
            if (fb != null)
                fb.Operation(--extrinsicstate);

            // 判断是否已经创建了字母C
            AbstractFlyweight fc = factory.GetFlyweight("C");
            if (fc != null)
                fc.Operation(--extrinsicstate);

            // 判断是否已经创建了字母D
            AbstractFlyweight fd = factory.GetFlyweight("D");
            if (fd != null)
            {
                fd.Operation(--extrinsicstate);
            }
            else
            {
                Console.WriteLine("驻留池中不存在字符串D");
                // 这时候就需要创建一个对象并放入驻留池中
                var d = new EntityFlyweight("D");
                factory.flyweights.Add("D", d);
            }

        }
    }
}
