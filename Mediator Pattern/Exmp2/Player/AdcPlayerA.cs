using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// 玩家A adc
    /// </summary>
    class AdcPlayerA : AbstractPlayer
    {
        /// <summary>
        /// 遭受攻击时候， A声明减少， 对应攻击者HP增加
        /// </summary>
        /// <param name="num"></param>
        /// <param name="mediator"></param>
        public override void ChangeHP(int num, AbstractMediator mediator)
        {
            mediator.Aembattled(num);
        }
    }
}
