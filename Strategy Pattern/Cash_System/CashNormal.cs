using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 正常收费类
    /// </summary>
    class CashNormal : CashSuper
    {
        /// <summary>
        /// 正常收费，计算价格并返回价格
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
