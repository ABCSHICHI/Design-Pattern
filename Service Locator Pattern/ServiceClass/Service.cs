using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Locator_Pattern
{
    /// <summary>
    /// 服务：实际处理请求的服务。
    /// </summary>
    public interface Service
    {
        string GetName();
        void Execute();
    }
}
