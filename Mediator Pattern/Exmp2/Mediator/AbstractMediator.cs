using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// 中介者抽象类
    /// </summary>
    public abstract class AbstractMediator
    {
        protected AbstractPlayer A;
        protected AbstractPlayer B;

        protected AbstractMediator(AbstractPlayer a, AbstractPlayer b)
        {
            A = a;
            B = b;
        }
        /// <summary>
        /// A被B攻击
        /// </summary>
        /// <param name="num"></param>
        public abstract void Aembattled(int num);
        /// <summary>
        /// B被A攻击
        /// </summary>
        /// <param name="num"></param>
        public abstract void BEmbattled(int num);
    }
}
