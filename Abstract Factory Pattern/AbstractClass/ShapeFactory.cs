using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Pattern.EntityClass.ShapeClass;
using Abstract_Factory_Pattern.Interface;

namespace Abstract_Factory_Pattern.AbstractClass
{
    /// <summary>
    /// AbstractFactory扩展的工厂类： 图形抽象工厂
    /// </summary>
    public class ShapeFactory : AbstractFactory
    {
        public override Color GetColor(string color)
        {
            return null;
        }

        public override Shape GetShape(string shape)
        {
            if (shape == null)
            {
                return null;
            }
            if (shape.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shape.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shape.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
