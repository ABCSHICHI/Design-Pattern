using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    /// <summary>
    /// 客户类
    /// </summary>
    class Client
    {

        private const int _times = 10;
        private const string _defaultValue = "默认值";
        static void Main(string[] args)
        {
            //---------- 非使用Facade模式时，常见的用法--------------------
            Console.WriteLine("非使用Facade模式时，常见的方法");
            DrawLine dl = new DrawLine(_times);
            ShowData sd = new ShowData(_defaultValue);
            dl.DrawUnderline();
            dl.DrawMiddleline();
            sd.ShowParticularData(_times, _defaultValue);
            sd.ShowShortData(_defaultValue);
            //-------------------结束--------------------------------------
            Console.WriteLine();
            //---------- 使用Facade模式的用法--------------------
            Console.WriteLine("使用facade模式的用法");
            Facade fc = new Facade(_times, _defaultValue);
            fc.DrawPicture();
            fc.DrwaImage();
        }
    }
}
      

