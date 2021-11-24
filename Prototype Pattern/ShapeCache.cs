using Prototype_Pattern.AbstractClass;
using Prototype_Pattern.EntityClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();
        public static Shape GetShape(string shapeId)
        {
            Shape cachedShape = shapeMap[shapeId];
            return (Shape)cachedShape.Clone();
        }

        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.SetId("1");
            shapeMap.Add(circle.GetId(), circle);

            Square square = new Square();
            square.SetId("2");
            shapeMap.Add(square.GetId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("3");
            shapeMap.Add(rectangle.GetId(), rectangle);
        }
    }
}
