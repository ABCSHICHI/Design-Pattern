using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    //聚集抽象类
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();//创建迭代器
    }
}
