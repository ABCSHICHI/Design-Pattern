using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.OrchardistClass;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Orchard orchard = new Orchard();//果园实例
            orchard.Attach(new Apple());//向果园中添加苹果树
            orchard.Attach(new Orange());//向果园中添加橘子树

            orchard.Accept(new LoosenOrchardist());//松土果农为果树松土

            Console.WriteLine("====···==···==···==···==···==···=");

            orchard.Accept(new ManureOrchardist());//浇水果农为果树浇水


        }
    }
}
