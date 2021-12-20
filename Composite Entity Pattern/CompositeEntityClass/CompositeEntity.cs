using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Entity_Pattern
{
    /// <summary>
    /// 组合实体
    /// 注：它是主要的实体bean，它可以是粗粒的，或者可以是包含粗粒度对象，用于持续生命周期
    /// </summary>
    class CompositeEntity
    {
        private CoarseGrainedObject cgo = new CoarseGrainedObject();
        public void SetData(string data_1, string data_2)
        {
            cgo.SetData(data_1, data_2);
        }

        public string[] GetData()
        {
            return cgo.GetData();
        }
    }
}
