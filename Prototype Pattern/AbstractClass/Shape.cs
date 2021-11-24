using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.AbstractClass
{
    /// <summary>
    /// 实现了ICloneable接口的抽象类
    /// </summary>
    public abstract class Shape : ICloneable
    {
        private string id;
        protected string type;

        public abstract void Draw();

        public string GetType()
        {
            return type;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public object Clone()
        {
            object clone = null;
            try
            {
                clone = MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine("异常：" + e.Message);
            }
            return clone;
        }
    }
}
