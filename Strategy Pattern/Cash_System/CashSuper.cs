using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 收费父类：
    /// 接收现金，AcceptCash为 正常收费、打折收费、返利收费 提供方法
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 收取现金
        /// </summary>
        /// <param name="money">当前价格</param>
        /// <returns></returns>
        public abstract double AcceptCash(double money);
    }
}
