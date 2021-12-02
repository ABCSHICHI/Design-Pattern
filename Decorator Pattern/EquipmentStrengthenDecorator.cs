using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pattern.WeaponClass;

namespace Decorator_Pattern
{
    class EquipmentStrengthenDecorator : BaseEquipmentDecorator
    {
        public EquipmentStrengthenDecorator(AbstractEquipment equipment) : base(equipment)
        {
        }

        public override void Attack()
        {
            base.Attack();
            Strengthen();
        }

        public void Strengthen()
        {
            Console.WriteLine("武器被强化");
        }
    }
}
