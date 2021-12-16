using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    /// <summary>
    /// 状态接口类
    /// </summary>
    public abstract class State
    {
        protected Context m_Context = null;

        public State(Context theContext)
        {
            m_Context = theContext;
        }

        public abstract void Handle(int value);
    }

    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context theContext) : base(theContext)
        {
        }

        public override void Handle(int value)
        {
            Console.WriteLine("ConcreteStateA.Handle");
            if (value > 10)
            {
                m_Context.SetState(new ConcreteStateB(m_Context));
            }
        }
    }

    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context theContext) : base(theContext)
        {
        }

        public override void Handle(int value)
        {
            Console.WriteLine("ConcreteStateB.Handle");
            if (value > 20)
            {
                m_Context.SetState(new ConcreteStateC(m_Context));
            }
        }
    }

    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context theContext) : base(theContext)
        {
        }

        public override void Handle(int value)
        {
            Console.WriteLine("ConcreteStateC.Handle");
            if (value > 30)
            {
                m_Context.SetState(new ConcreteStateA(m_Context));
            }
        }
    }
}
