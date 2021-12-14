using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main1(string[] args)
        {
            UniteNationSecurityCouncil UNSC = new UniteNationSecurityCouncil();

            USA c1 = new USA(UNSC);
            Iraq c2 = new Iraq(UNSC);

            UNSC.Colleague1 = c1;
            UNSC.Colleague2 = c2;

            c1.Declare("不准研制核武器，否则要发动战争！");
            c2.Declare("我们灭有核武器，也不怕侵略。");
        }
    }
}
