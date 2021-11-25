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
            //创建实体类对象
            ShapeCache.LoadCache();

            //克隆对象
            Shape cloneShape1 = (Shape)ShapeCache.GetShape("1");
            Shape cloneShape2 = (Shape)ShapeCache.GetShape("2");
            Shape cloneShape3 = (Shape)ShapeCache.GetShape("3");

            //打印克隆对象的属性
            Console.WriteLine("Shape: {0}, {1}, {2}", cloneShape1.GetType(), cloneShape2.GetType(), cloneShape3.GetType());
        }
    }
}
