using Decorator_Pattern.WeaponClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class BaseEquipmentDecorator : AbstractEquipment
    {
        private AbstractEquipment _equipment = null;

        public BaseEquipmentDecorator(AbstractEquipment equipment)
        {
            _equipment = equipment;
        }

        public override void Attack()
        {
            _equipment.Attack();
        }
    }
}
