using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercepting_Filter_Pattern
{
    /// <summary>
    /// target对象处理程序
    /// </summary>
    public class Target
    {
        public void Execute(string request)
        {
            Console.WriteLine("执行请求：" + request);
        }
    }
}
