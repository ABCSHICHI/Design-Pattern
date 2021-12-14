using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    /// <summary>
    /// 国家类
    /// </summary>
    public abstract class Country
    {
        protected UniteNations mediator;

        protected Country(UniteNations mediator)
        {
            this.mediator = mediator;
        }
    }
}
