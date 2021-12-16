using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 打折收费类
    /// </summary>
    class CashRebate : CashSuper
    {
        private double moneyRebate = 1.0d;//定义折扣

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
