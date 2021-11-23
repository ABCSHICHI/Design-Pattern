using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.Common
{
    /// <summary>
    /// 该版本是线程安全的
    /// 通过对一个过线程共享的对象进行加锁操作，保证了在同一时刻只有一个线程在执行lock{}里的代码。
    /// 当第一个线程在进行instance判断或创建时，后续线程必须等待直到前一线程执行完毕，因此保证了只有第一个线程能够创建instance实例
    /// 但不幸的是，因为每次对instance的请求都会进行lock操作，其性能是不佳的。
    /// 需要注意的是，这里使用了一个private static object变量进行锁定，
    /// 这是因为当如果对一个外部类可以访问的对象进行锁定时会导致性能低下甚至死锁。
    /// 因此通常来说为了保证线程安全，进行加锁的对象应该是private的
    /// </summary>
    public class Singleton_safe
    {
        private static Singleton_safe instance = null;
        private static readonly object obj = new object();
        private Singleton_safe() { }
        public Singleton_safe Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                        instance = new Singleton_safe();
                    return instance;
                }
            }
        }

        
    }
}
