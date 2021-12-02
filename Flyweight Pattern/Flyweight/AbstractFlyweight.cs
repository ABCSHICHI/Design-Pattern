using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    /// <summary>
    /// 抽象享元类
    /// </summary>
    public abstract class AbstractFlyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
