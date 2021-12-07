using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Light
    {
        public void On()
        {
            Console.WriteLine("light's on");
        }

        public void Off()
        {
            Console.WriteLine("light's off");
        }
    }
}
