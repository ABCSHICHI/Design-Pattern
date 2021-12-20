using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Entity_Pattern
{
    /// <summary>
    /// 创建粗粒度对象
    /// 注：包含依赖对象， 它有自己的声明周期，也能够管理依赖对象的声明周期
    /// </summary>
    class CoarseGrainedObject
    {
        DependentObject1 do_1 = new DependentObject1();
        DependentObject2 do_2 = new DependentObject2();

        public void SetData(string data_1, string data_2)
        {
            do_1.Data = data_1;
            do_2.Data = data_2;
        }

        public string[] GetData()
        {
            return new string[] { do_1.Data, do_2.Data };
        }
    }
}
