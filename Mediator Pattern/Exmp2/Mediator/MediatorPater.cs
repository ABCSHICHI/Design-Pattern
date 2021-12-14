using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// 具体中介者
    /// </summary>
    class MediatorPater : AbstractMediator
    {
        private AbstractPlayer a;
        private AbstractPlayer b;

        public MediatorPater(AbstractPlayer a, AbstractPlayer b):base(a,b)
        {
        }

        public override void Aembattled(int num)
        {
            A.HP -= num;
            B.HP = num * 0.1 + B.HP;
        }

        public override void BEmbattled(int num)
        {
            B.HP -= num + A.HP * 0.01;
            A.HP = A.HP + num * 0.01;
        }
    }
}
