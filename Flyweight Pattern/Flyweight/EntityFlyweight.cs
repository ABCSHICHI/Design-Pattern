using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern.Flyweight
{
    /// <summary>
    /// 具体享元对象
    /// </summary>
    class EntityFlyweight : AbstractFlyweight
    {
        //内部状态
        private readonly string _intrinsicstate;

        public EntityFlyweight(string intrinsicstate)
        {
            _intrinsicstate = intrinsicstate;
        }

        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体实现类： instrinsicstate {0}, extrinsicstate {1}", _intrinsicstate, extrinsicstate);
        }
    }
}
