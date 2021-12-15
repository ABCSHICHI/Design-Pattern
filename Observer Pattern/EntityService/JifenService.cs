using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class JifenService
    {
        int initNum = 0;
        public void AddJifen(string userName, int num)
        {
            initNum += num;
            Console.WriteLine("{0}增加积分成功，当前积分：{1}", userName, initNum);
        }
    }
}
