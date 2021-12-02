using Flyweight_Pattern.Flyweight;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    /// <summary>
    /// 享元工厂
    /// </summary>
    class FlyweightFactory
    {
        // 最好使用泛型Dictionary<string,Flyweighy>
        //public Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();
        public Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("A", new EntityFlyweight("A"));
            flyweights.Add("B", new EntityFlyweight("B"));
            flyweights.Add("C", new EntityFlyweight("C"));
        }

        public AbstractFlyweight GetFlyweight(string key)
        {
            //return flyweights[key] as AbstractFlyweight;

            //更好的实现方法
            AbstractFlyweight flyweight = flyweights[key] as AbstractFlyweight;
            if(flyweight == null)
            {
                Console.WriteLine("驻留池中不包含字符串：" + key + ",重新创建");
                flyweight = new EntityFlyweight(key);
            }
            return flyweight;
        }
    }
}
