using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Interface
{
    /// <summary>
    /// 补充：
    /// 1.接口不能包含字段，可以包含：方法、属性、索引器、事件
    /// 2.接口成员一定是 public abstract，但是不能写
    /// 3. 接口成员不能实现，全部默认抽象
    /// 4. 类与类（包括抽象类）单继承，接口与接口或者类 是多实现
    /// </summary>
    public interface Item
    {
        string Name();
        Packing Packing();
        float Price();
    }
}
