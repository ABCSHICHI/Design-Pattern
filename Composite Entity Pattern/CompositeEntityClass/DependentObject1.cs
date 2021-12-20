using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Entity_Pattern
{
    /// <summary>
    /// 依赖对象_1
    /// 注：一个持续生命周期依赖于粗粒度对象的对象
    /// </summary>
    public class DependentObject1
    {
        private string data;

        public string Data { get => data; set => data = value; }
    }
}
