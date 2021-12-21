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
    class AuthenticationFilter : Filter
    {
        public void Execute(string request)
        {
            Console.WriteLine("验证请求: " + request);
        }
    }
}
