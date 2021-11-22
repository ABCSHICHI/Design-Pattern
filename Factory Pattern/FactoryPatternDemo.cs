using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern.Interface;
using Design_Pattern.ShapeFactoryClass;
namespace Design_Pattern
{
    class FactoryPatternDemo
    {
        public static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //获取 cirle 的对象， 并调用它的draw方法
            Shape shape1 = shapeFactory.GetShape("CIRCLE");
            //调用Cirle的对象， 并调用它的draw方法
            shape1.draw();

            //获取 Rectangle 的对象， 并调用它的draw方法
            Shape shape2 = shapeFactory.GetShape("RECTANGLE");
            //调用Cirle的对象， 并调用它的draw方法
            shape2.draw();

            //获取 Square 的对象， 并调用它的draw方法
            Shape shape3 = shapeFactory.GetShape("SQUARE");
            //调用Cirle的对象， 并调用它的draw方法
            shape3.draw();
        }
    }
}
