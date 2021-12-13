using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;//定义一个具体聚集对象
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;//初始化时将具体的聚集对象传入
        }

        public override object CurrentItem()
        {
            return aggregate[current];//返回当前的聚集对象
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()//判断当前是否遍历到结尾。到结尾返回true;
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object Next()//得到聚集的下一个对象
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
            {
                return aggregate[current];
            }
            return ret;
        }
    }
}
