using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern.Interpreter
{
    class TerminalExpression: IExpression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }

            return false;
        }
    }
}
