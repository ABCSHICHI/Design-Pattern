using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Entity_Pattern
{
    class Client
    {
        private CompositeEntity compositeEntity = new CompositeEntity();
        public void PrintData()
        {
            for (int i = 0; i < compositeEntity.GetData().Length; i++)
            {
                Console.WriteLine("Data: " + compositeEntity.GetData()[i]);
            }
        }

        public void SetData(string data_1, string data_2)
        {
            compositeEntity.SetData(data_1, data_2);
        }
    }
}
