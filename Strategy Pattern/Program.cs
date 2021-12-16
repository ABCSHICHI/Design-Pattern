using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        private static double total = 10.0d;//待支付
        private static string moneyRebate = "0.7";//折扣
        private static double moneyCondition = 5.0d;   //定义达到返利条件的价格
        private static double moneyReturn = 2.0d;  //定义返利额度
        static void Main(string[] args)
        {
            CashContext cashContext = new CashContext();
            //正常收费
            cashContext.Setbehavior(new CashNormal());
            Console.WriteLine("正常收费：" + cashContext.GetResult(total));

            //打折后收费
            cashContext.Setbehavior(new CashRebate(moneyRebate));
            Console.WriteLine("打折后收费：" + cashContext.GetResult(total));

            //返现收费
            cashContext.Setbehavior(new CashReturn(moneyCondition, moneyReturn));
            Console.WriteLine("返现收费：" + cashContext.GetResult(total));
        }
    }
}
