using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    /// <summary>
    /// 清空命令块
    /// </summary>
    class NoCommand : ICommand
    {
        public void Excute()
        {
            Console.WriteLine("No command was excuted!");
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
