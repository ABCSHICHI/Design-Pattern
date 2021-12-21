using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercepting_Filter_Pattern
{
    /// <summary>
    /// 实体过滤器
    /// </summary>
    class DebugFilter : Filter
    {
        public void Execute(string request)
        {
            Console.WriteLine("请求 打印日志：" + request);
        }
    }
}
