using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.Common
{
    /// <summary>
    /// 双重检查锁
    /// 试图去避免每次访问都进行加锁操作并实现线程安全。
    /// </summary>
    public class Singleton_double_lock
    {
        private static Singleton_double_lock instance = null;
        private static object obj = new object();
        private Singleton_double_lock() { }

        public static Singleton_double_lock Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton_double_lock();
                    }
                }

                return instance;
            }
        }
    }
}
