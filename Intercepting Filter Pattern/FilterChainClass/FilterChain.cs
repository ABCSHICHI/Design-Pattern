using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercepting_Filter_Pattern
{
    /// <summary>
    /// 过滤器链
    /// 注： 过滤器链有多个过滤器，并在target上定义的顺序执行这些过滤器
    /// </summary>
    class FilterChain
    {
        private List<Filter> filters = new List<Filter>();
        private Target target;

        public void AddFilter(Filter filter)
        {
            filters.Add(filter);
        }

        public void Execute(string request)
        {
            foreach (var item in filters)
            {
                item.Execute(request);
            }
            target.Execute(request);
        }

        public void SetTarget(Target target)
        {
            this.target = target;
        }
    }
}
