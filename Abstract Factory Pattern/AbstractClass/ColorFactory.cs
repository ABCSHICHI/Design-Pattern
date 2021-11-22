using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory_Pattern.EntityClass.ColorClass;
using Abstract_Factory_Pattern.Interface;

namespace Abstract_Factory_Pattern.AbstractClass
{
    /// <summary>
    /// AbstractFactory扩展的工厂类：颜色抽象工厂
    /// </summary>
    public class ColorFactory : AbstractFactory
    {
        public override Color GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("RED"))
            {
                return new Red();
            }
            else if (color.Equals("BLUE"))
            {
                return new Blue();
            }
            else if (color.Equals("GREEN"))
            {
                return new Green();
            }
            return null;
        }

        public override Shape GetShape(string shape)
        {
            return null;
        }
    }
}
