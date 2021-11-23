using Builder_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.EntityClass
{
    /// <summary>
    /// 包装纸实体类
    /// </summary>
    class Wrapper : Packing
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
