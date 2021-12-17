using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.OrchardistClass;

namespace Visitor_Pattern
{
    public class Orange : Fruit
    {
        public override void Accept(Orchardist orchardist)
        {
            orchardist.VisitOrange(this);
        }

        public void PlantOrange()
        {
            Console.WriteLine("培育橘子树！");
        }
    }
}
