using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.Common
{
    /// <summary>
    /// 实现非常的简单，但是却又是线程安全的
    /// C#的静态构造函数只有在当其类的实例被创建或者有静态成员被引用时执行，在整个应用程序域中只会被执行一次
    /// 一些瑕疵：
    /// 1.单例类还存在其他静态成员，当其他类第一次引用这些成员时便会创建该instance。
    /// 2.只有.NET中才具有beforefieldinit特性,且在.Net 1.1以前的编译器不支持
    /// </summary>
    public class Singleton_simple
    {
        private static readonly Singleton_simple instance = null;
        /// <summary>
        /// 显式的静态构造函数 告诉 c#编译器 在其内容实例化之前不要忘记其类型
        /// </summary>
        static Singleton_simple() { }
        private Singleton_simple() { }

        public static Singleton_simple Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
