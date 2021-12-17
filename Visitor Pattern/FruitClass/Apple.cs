using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.OrchardistClass;

namespace Visitor_Pattern
{
    public class Apple : Fruit
    {
        public override void Accept(Orchardist orchardist)
        {
            orchardist.VisitApple(this);
        }

        public void PlantApple()
        {
            Console.WriteLine("培育苹果树！");
        }
    }
}
