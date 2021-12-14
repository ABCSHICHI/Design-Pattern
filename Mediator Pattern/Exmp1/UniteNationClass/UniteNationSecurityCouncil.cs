using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// 联合国——具体中介者
    /// </summary>
    class UniteNationSecurityCouncil : UniteNations
    {
        private USA colleague1;
        private Iraq colleague2;

        public USA Colleague1 { set => colleague1 = value; }
        public Iraq Colleague2 { set => colleague2 = value; }

        public override void Declare(string message, Country colleague)
        {
            if (colleague == colleague1)
                colleague2.GetMessage(message);
            else
                colleague1.GetMessage(message);
        }

    }
}
