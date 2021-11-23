using Builder_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Common
{
    class Meal
    {
        private List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0;
            foreach (Item item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine("Item:{0}, Packing:{1}, Price:{2}",
                            item.Name(), item.Packing().Pack(), item.Price());
            }
        }
    }
}
