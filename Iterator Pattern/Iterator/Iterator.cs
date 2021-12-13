using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public abstract class Iterator
    {
        //定义统一接口
        public abstract object First();//开始对象
        public abstract object Next();//得到下一对象
        public abstract bool IsDone();//判断是否到结尾
        public abstract object CurrentItem();//当前对象
    }
}
