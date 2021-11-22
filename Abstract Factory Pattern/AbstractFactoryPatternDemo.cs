using Abstract_Factory_Pattern.AbstractClass;
using Abstract_Factory_Pattern.Interface;
using Abstract_Factory_Pattern.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class AbstractFactoryPatternDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("验证形状工厂的功能");
            //获取形状工厂
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");
            //获取形状为Circle 的对象
            Shape circle = shapeFactory.GetShape("CIRCLE");
            //调用Circle的方法
            circle.draw();

            //获取形状为 Rectangle 的对象
            Shape rectangle = shapeFactory.GetShape("RECTANGLE");
            //调用 Rectangle 的方法
            rectangle.draw();

            //获取形状为 Square 的对象
            Shape square = shapeFactory.GetShape("SQUARE");
            //调用 Square 的方法
            square.draw();


            Console.WriteLine();
            Console.WriteLine("验证颜色工厂的功能");


            //获取形状工厂
            AbstractFactory colorFactory = FactoryProducer.GetFactory("COLOR");
            //获取形状为Circle 的对象
            Color red = colorFactory.GetColor("RED");
            //调用Circle的方法
            red.fill();

            //获取形状为 Rectangle 的对象
            Color blue = colorFactory.GetColor("BLUE");
            //调用 Rectangle 的方法
            red.fill();

            //获取形状为 Square 的对象
            Color green = colorFactory.GetColor("GREEN");
            //调用 Square 的方法
            red.fill();

            Console.WriteLine();
        }
    }
}
