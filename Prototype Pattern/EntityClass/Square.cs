using Prototype_Pattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.EntityClass
{
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }

        public Square()
        {
            type = "Square";
        }
    }
}
