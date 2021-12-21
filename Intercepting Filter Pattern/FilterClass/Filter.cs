using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercepting_Filter_Pattern
{
    /// <summary>
    /// 过滤器 
    /// 注： 过滤器在请求处理程序执行请求之前或者之后，执行某些任务
    /// </summary>
    public interface Filter
    {
        void Execute(string request);
    }
}
