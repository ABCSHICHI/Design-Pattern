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
    /// 冷饮类
    /// </summary>
    public abstract class ColorDrink : Item
    {
        public string Name()
        {
            throw new NotImplementedException();
        }

        public Packing Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }
}
