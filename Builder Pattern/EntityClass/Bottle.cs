using Builder_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.EntityClass
{
    /// <summary>
    /// 瓶子实体类
    /// </summary>
    class Bottle : Packing
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
