using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.Common
{
    public class Singleton
    {
        //创建一个对象
        private static Singleton instance = new Singleton();

        //构造函数 为 privaite， 这样该类不会实例化
        private Singleton() { }

        //获取唯一可用的对象
        public static Singleton GetInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("hello world");
        }
    }
}
