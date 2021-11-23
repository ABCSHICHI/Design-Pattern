using Builder_Pattern.ItemAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.EntityClass.ItemEntity
{
    class Pepsi : ColdDrink
    {
        public override float Price()
        {
            return 35.0f;
        }
        public override string Name()
        {
            return "Pepsi";
        }
    }
}
