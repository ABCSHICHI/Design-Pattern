using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// 抽象玩家类
    /// </summary>
    public abstract class AbstractPlayer
    {
        /// <summary>
        /// 生命值
        /// </summary>
        public double HP { get; set; }

        /// <summary>
        /// 遭受攻击时候，生命值减少，对应攻击者HP增加
        /// </summary>
        /// <param name="num"></param>
        public abstract void ChangeHP(int num, AbstractMediator mediator);
    }
}
