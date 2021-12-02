using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.WeaponClass
{
    class Gun : AbstractEquipment
    {
        public override void Attack()
        {
            Console.WriteLine("用抢攻击");
        }
    }
}
