using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    /// <summary>
    /// 子系统1
    /// </summary>
    class DrawLine
    {
        private int _point;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">画线数量</param>
        public DrawLine(int point)
        {
            _point = point;
        }

        /// <summary>
        /// 画下划线
        /// </summary>
        public void DrawUnderline()
        {
            for (int i = 0; i < _point; i++)
                Console.Write("_");
        }
        /// <summary>
        /// 画中划线
        /// </summary>
        public void DrawMiddleline()
        {
            for(int i = 0; i < _point; i++)
                Console.Write("-~");
        }

    }
}
