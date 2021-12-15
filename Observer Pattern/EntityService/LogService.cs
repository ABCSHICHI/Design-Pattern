using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class LogService
    {
        public void PrintLof(string userId, string _log)
        {
            Console.WriteLine(userId + " 打印：" + _log);
        }
    }
}
