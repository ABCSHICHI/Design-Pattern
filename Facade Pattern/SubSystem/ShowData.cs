using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    /// <summary>
    /// 子系统2，
    /// </summary>
    class ShowData
    {
        private string _defaultValue;

        public ShowData(string defaultValue)
        {
            _defaultValue = defaultValue;
        }

        /// <summary>
        /// 显示数据详情
        /// </summary>
        /// <param name="time"></param>
        /// <param name="outsideValue"></param>
        public void ShowParticularData(int time, string outsideValue)
        {
            for (int i = 0; i < time; i++)
            {
                Console.Write(outsideValue);
                Console.Write("|");
            }

            Console.WriteLine(" ");
        }

        public void ShowShortData(string outsideValue)
        {
            Console.WriteLine(_defaultValue + ":" + outsideValue);
        }
    }
}
