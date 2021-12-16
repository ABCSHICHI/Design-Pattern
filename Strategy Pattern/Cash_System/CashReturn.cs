using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    /// <summary>
    /// 返利收费类
    /// 需要定义自己的返利方法
    /// </summary>
    class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;   //定义达到返利条件的价格
        private double moneyReturn = 0.0d;  //定义返利额度

        public CashReturn(double moneyCondition, double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}
