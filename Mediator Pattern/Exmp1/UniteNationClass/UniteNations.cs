using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// 联合国机构类
    /// </summary>
    public abstract class UniteNations
    {
        //声明
        public abstract void Declare(string message, Country colleague);
    }
}
