using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class LightOnCommand : ICommand
    {
        // ConcreteCommand中一个Receiver，多用组合少用继承
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Excute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}
