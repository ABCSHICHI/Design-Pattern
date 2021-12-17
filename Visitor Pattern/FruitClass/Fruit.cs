using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.OrchardistClass;

namespace Visitor_Pattern
{
    public abstract class Fruit
    {
        public abstract void Accept(Orchardist orchardist);
    }
}
