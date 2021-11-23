using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.Common
{
    /// <summary>
    /// 1、懒汉式，线程不安全
    /// 该版本在多线程下是不安全的，会创建多个实例，请不要在生产环境中使用！
    /// 因为如果两个线程同时运行到if(instance==null)判断时，
    /// 就会创建两个实例，这是违背单例模式的初衷的。
    /// 实际上在后面那个线程进行判断是已经生成了一个实例，
    /// 但是对于不同的线程来说除非进行了线程间的通信，否则它是不知道的。
    /// </summary>
    public class Singleton_not_safe
    {
        private static Singleton_not_safe instance = null;
        private Singleton_not_safe() { }

        public static Singleton_not_safe Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton_not_safe();
                return instance;
            }
        }

    }
}
