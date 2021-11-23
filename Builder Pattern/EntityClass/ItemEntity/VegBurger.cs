using Builder_Pattern.ItemAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.EntityClass.ItemEntity
{
    class VegBurger : Burger
    {
        public override float Price()
        {
            return 54.5f;
        }
        public override string Name()
        {
            return "VegBurger";
        }
    }
}
