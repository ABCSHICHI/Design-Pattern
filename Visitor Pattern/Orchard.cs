using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.OrchardistClass;

namespace Visitor_Pattern
{
    /// <summary>
    /// 果园
    /// </summary>
    class Orchard
    {
        List<Fruit> fruits = new List<Fruit>(); //果园种植的果树
        /// <summary>
        /// 增加水果
        /// </summary>
        /// <param name="fruit"></param>
        public void Attach(Fruit fruit)
        {
            fruits.Add(fruit);
        }
        /// <summary>
        /// 移除水果
        /// </summary>
        /// <param name="fruit"></param>
        public void Detach(Fruit fruit)
        {
            fruits.Remove(fruit);
        }

        /// <summary>
        /// 果树接收果农培育
        /// </summary>
        /// <param name="orchardist"></param>
        public void Accept(Orchardist orchardist)
        {
            foreach (var item in fruits)
            {
                item.Accept(orchardist);
                Console.WriteLine("====--=--=---===--===--=--=---===--===--=--=---===--==");
            }
        }
    }
}
