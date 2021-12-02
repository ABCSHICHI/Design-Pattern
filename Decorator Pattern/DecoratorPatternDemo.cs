using Decorator_Pattern.WeaponClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class DecoratorPatternDemo
    {
        public static void Main()
        {
            AbstractEquipment gun = new Gun();
            gun = new EquipmentStrengthenDecorator(gun);
            gun.Attack();
        }
    }
}
