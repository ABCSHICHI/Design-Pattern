using Abstract_Factory_Pattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.Producer
{
    /// <summary>
    /// 工厂生成器，通过传递形状或者颜色信息来获取工厂
    /// </summary>
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals("SHAPE"))
                return new ShapeFactory();
            else if (choice.Equals("COLOR"))
                return new ColorFactory();
            return null;
        }
    }
}
