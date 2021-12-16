using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{

    /// <summary>
    /// 状态拥有者
    /// </summary>
    public class Context
    {
        /// <summary>
        /// "状态"属性 对象
        /// </summary>
        State m_state = null;

        /// <summary>
        /// 请求状态
        /// </summary>
        /// <param name="value"></param>
        public void Request(int value)
        {
            m_state.Handle(value);
        }
        /// <summary>
        /// 指定当前状态
        /// </summary>
        /// <param name="theState"></param>
        public void SetState(State theState)
        {
            Console.WriteLine("Context.SetState:" + theState);
            m_state = theState;
        }
    }
}
