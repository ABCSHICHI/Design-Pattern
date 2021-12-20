using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Entity_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.SetData("Test", "Data");
            client.PrintData();
            client.SetData("Second Test", "Data1");
            client.PrintData();
            Console.Read();
        }
    }
}
