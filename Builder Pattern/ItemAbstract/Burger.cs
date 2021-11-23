using Builder_Pattern.EntityClass;
using Builder_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.ItemAbstract
{
    /// <summary>
    /// 汉堡类
    /// </summary>
    public abstract class Burger : Item
    {
        public string Name()
        {
            throw new NotImplementedException();
        }

        public Packing Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}
