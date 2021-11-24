using Prototype_Pattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.EntityClass
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }

        public Rectangle()
        {
            type = "Rectangle";
        }
    }
}
