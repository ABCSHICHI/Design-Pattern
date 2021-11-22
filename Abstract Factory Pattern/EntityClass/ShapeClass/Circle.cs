using Abstract_Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.EntityClass.ShapeClass
{
    /// <summary>
    /// 圆型 实体类
    /// </summary>
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method");
        }
    }
}
