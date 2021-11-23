using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.Common
{
    /// <summary>
    /// 完全懒汉实例化:
    /// 写法上实现了上一版本 Singleton_simple.cs 的瑕疵，
    /// 通过内嵌类的方式先实现了只有在真正应用Instance时才进行实例化。
    /// 其性能表现与上一版本无异。
    /// </summary>
    public class Singleton_WholeLazy
    {
        private Singleton_WholeLazy() { }
        public static Singleton_WholeLazy Instance { get { return Nested.instance; } }
        private class Nested
        {
            static Nested() { }
            internal static readonly Singleton_WholeLazy instance = new Singleton_WholeLazy();

        }
    }
}
