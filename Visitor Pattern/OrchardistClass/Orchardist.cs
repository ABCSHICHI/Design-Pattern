using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern.OrchardistClass
{
    public abstract class Orchardist
    {
        /// <summary>
        /// 果农种植苹果
        /// </summary>
        /// <param name="apple"></param>
        public abstract void VisitApple(Apple apple);

        /// <summary>
        /// 果农种植橘子
        /// </summary>
        /// <param name="orange"></param>
        public abstract void VisitOrange(Orange orange);
    }
}
