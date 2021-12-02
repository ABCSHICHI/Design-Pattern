using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.WeaponClass
{
    class Sword : AbstractEquipment
    {
        public override void Attack()
        {
            Console.WriteLine("用剑攻击");
        }
    }
}
