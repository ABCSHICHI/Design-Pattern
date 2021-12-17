using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern.OrchardistClass
{
    /// <summary>
    /// 负责松土的果农
    /// </summary>
    class LoosenOrchardist : Orchardist
    {
        public override void VisitApple(Apple apple)
        {
            apple.PlantApple();
            Console.WriteLine("果农为苹果树松土！");
        }

        public override void VisitOrange(Orange orange)
        {
            orange.PlantOrange();
            Console.WriteLine("果农为橘子树松土");
        }
    }
}
