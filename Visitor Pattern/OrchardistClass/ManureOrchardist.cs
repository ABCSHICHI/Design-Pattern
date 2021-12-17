using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern.OrchardistClass
{
    /// <summary>
    /// 负责浇水的果农
    /// </summary>
    class ManureOrchardist : Orchardist
    {
        public override void VisitApple(Apple apple)
        {
            apple.PlantApple();
            Console.WriteLine("果农为苹果树浇水");
        }

        public override void VisitOrange(Orange orange)
        {
            orange.PlantOrange();
            Console.WriteLine("果农为橘子树浇水");
        }
    }
}
