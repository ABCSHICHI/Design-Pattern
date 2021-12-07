using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var control = new RemoteControl();
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            control.SetCommand(0, lightOnCommand, lightOffCommand);
            control.OnButtonWasPushed(0);
        }
    }
}
