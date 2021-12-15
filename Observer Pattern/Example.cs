using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class Example
    {
         public static void Main()
        {
            try
            {
                Console.WriteLine("*******************观察者模式事件委托实现*******************");
                Cat cat = new Cat();
                cat.MiaoHandler += new Mouse().Run;
                cat.MiaoHandler += new Dog().Wang;
                cat.MiaoHandler += new Stealer().Hide;
                cat.MiaoHandler += new Baby().Cry;
                cat.MiaoHandler += new Mouse().Run;
                cat.MiaoHandler += new Mother().Whisper;

                cat.MiaoEvent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
     
    }
    /// <summary>
    /// 神奇猫（Cat）类
    /// </summary>
    public class Cat
    {
        public event Action MiaoHandler;//无返回值的委托
        public void MiaoEvent()
        {
            Console.WriteLine("{0} 尖叫....", this.GetType().Name);
            if (MiaoHandler != null)
            {
                MiaoHandler?.Invoke();
            }
        }
    }
    /// <summary>
    /// 老鼠（Mouse）类
    /// </summary>
    public class Mouse
    {
        public void Run()
        {
            Console.WriteLine("{0} 跑路了", this.GetType().Name);
        }
    }
    /// <summary>
    /// 狗（Dog）类
    /// </summary>
    public class Dog
    {
        public void Wang()
        {
            Console.WriteLine("{0} 狂叫", this.GetType().Name);
        }

    }
    /// <summary>
    /// 小偷（Stealer）类
    /// </summary>
    public class Stealer
    {
        public void Hide()
        {
            Console.WriteLine("{0} 藏在角落中", this.GetType().Name);
        }
    }

    /// <summary>
    /// 婴儿（Baby）类
    /// </summary>
    public class Baby
    {
        public void Cry()
        {
            Console.WriteLine("{0} 尖锐的哭叫", this.GetType().Name);
        }
    }
    /// <summary>
    /// 妈妈（Mother）类
    /// </summary>
    public class Mother
    {
        public void Whisper()
        {
            Console.WriteLine("{0} 低语", this.GetType().Name);
        }
    }
}
