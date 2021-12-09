using Interpreter_Pattern.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class InterpreterPatternDemo
    {
        //Robert 和 John 是男性
        public static IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //Julie 是一个已婚的女性
        public static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }
        static void Main(string[] args)
        {
            IExpression isMale = GetMaleExpression();
            IExpression isMarriedWoman = GetMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.Interpret("John"));
            Console.WriteLine("Julie id a married women? " + isMarriedWoman.Interpret("Married Julie"));
        }
    }
}
