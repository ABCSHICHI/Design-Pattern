using Prototype_Pattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    class PrototypePatternDemo
    {
        static void Main(string[] args)
        {
            ShapeCache.LoadCache();
            Shape cloneShape1 = (Shape)ShapeCache.GetShape("1");
            Shape cloneShape2 = (Shape)ShapeCache.GetShape("2");
            Shape cloneShape3 = (Shape)ShapeCache.GetShape("3");

            Console.WriteLine("Shape: {0}, {1}, {2}", cloneShape1.GetType(), cloneShape2.GetType(), cloneShape3.GetType());
        }
    }
}
