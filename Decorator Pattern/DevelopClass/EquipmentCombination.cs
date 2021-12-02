using Decorator_Pattern.WeaponClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    /// <summary>
    /// 组合 实现业务子类拓展
    /// </summary>
    class EquipmentCombination
    {
        private AbstractEquipment _equipment = null;

        public EquipmentCombination(AbstractEquipment equipment)
        {
            _equipment = equipment;
        }

        public void Attack()
        {
            _equipment.Attack();
            Console.WriteLine("善恶值增加");
        }
    }
}
