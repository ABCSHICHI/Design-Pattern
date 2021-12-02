using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    /// <summary>
    ///  外观模式， 向外提供各个子系统的功能
    /// </summary>
    class Facade
    {
        private int _times;
        private string _defaultValue;
        private DrawLine dl;
        private ShowData sd;

        public Facade(int times, string defaultValue)
        {
            _times = times;
            _defaultValue = defaultValue;
            dl = new DrawLine(_times);
            sd = new ShowData(_defaultValue);
        }

        /// <summary>
        /// 画下划线，显示详细数据
        /// </summary>
        public void DrawPicture()
        {
            dl.DrawUnderline();
            sd.ShowParticularData(_times, _defaultValue);
        }

        public void DrwaImage()
        {
            dl.DrawMiddleline();
            sd.ShowShortData(_defaultValue);
        }
    }
}
