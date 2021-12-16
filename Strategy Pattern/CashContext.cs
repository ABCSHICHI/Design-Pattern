using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 提供接口
    /// </summary>
    class CashContext
    {
        //声明父类
        private CashSuper cs;
        /// <summary>
        /// 设置策略行为
        /// </summary>
        /// <param name="csuper">收费子类</param>
        public void Setbehavior(CashSuper csuper)
        {
            this.cs = csuper;
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
