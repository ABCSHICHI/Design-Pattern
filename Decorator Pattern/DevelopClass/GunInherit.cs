using Decorator_Pattern.WeaponClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    /// <summary>
    /// 继承 修改业务子类
    /// </summary>
    class GunInherit:Gun
    {
        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("善恶值增加");
        }
    }
}
