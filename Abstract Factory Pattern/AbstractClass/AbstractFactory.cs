using Abstract_Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.AbstractClass
{
    /// <summary>
    /// 抽象工厂
    /// 为 Color 和 Shape 对象创建抽象类来获取工厂。
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Color GetColor(string color);
        public abstract Shape GetShape(string shape);
    }
}
