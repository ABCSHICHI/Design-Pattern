using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    class AdcPlayerB : AbstractPlayer
    {
        /// <summary>
        /// 遭受攻击时候，b生命值减少，对应攻击者HP增加
        /// </summary>
        /// <param name="num"></param>
        /// <param name="mediator"></param>
        public override void ChangeHP(int num, AbstractMediator mediator)
        {
            mediator.BEmbattled(num);
        }
    }
}
