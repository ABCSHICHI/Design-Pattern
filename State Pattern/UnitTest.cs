using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    class UnitTest
    {
        static void Main()
        {
            Context theContext = new Context();
            //预加载 状态
            theContext.SetState(new ConcreteStateA(theContext));

            //根据参数，逐层加载的状态
            theContext.Request(5);
            Console.WriteLine("=================================");
            theContext.Request(15);
            Console.WriteLine("=================================");

            theContext.Request(25);
            Console.WriteLine("=================================");
            theContext.Request(35);
            Console.WriteLine("=================================");

        }
    }
}
