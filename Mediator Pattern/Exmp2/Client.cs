using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    class Client
    {
        static void Main()
        {
            AbstractPlayer a = new AdcPlayerA();
            a.HP = 200;
            AbstractPlayer b = new AdcPlayerB();
            b.HP = 200;

            AbstractMediator mediator = new MediatorPater(a, b);

            //a被b攻击
            Console.WriteLine("a玩家遭受B的20点攻击");
            a.ChangeHP(20, mediator);
            Console.WriteLine("a生命值>" + a.HP);
            Console.WriteLine("b生命值>" + b.HP);

            Console.WriteLine("");
            Console.WriteLine("b玩家遭受a的20点攻击");
            b.ChangeHP(20, mediator);
            Console.WriteLine("a生命值>" + a.HP);
            Console.WriteLine("b生命值>" + b.HP);
        }
    }
}
