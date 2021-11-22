using Design_Pattern.EntityClass;
using Design_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.ShapeFactoryClass
{
    /// <summary>
    /// 图形工厂， 生成基于给定信息的实体类对象
    /// </summary>
    class ShapeFactory
    {
        /// <summary>
        /// 获取形状类型对象
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null)
                return null;
            if (shapeType.Equals("CIRCLE"))
                return new Circle();
            else if (shapeType.Equals("RECTANGLE"))
                return new Rectangle();
            else if (shapeType.Equals("SQUARE"))
                return new Square();
            return null;
        }
    }
}
