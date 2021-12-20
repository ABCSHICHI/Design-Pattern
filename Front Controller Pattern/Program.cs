using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front_Controller_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontController frontController = new FrontController();
            frontController.DispatchRequest("HOME");
            frontController.DispatchRequest("STUDENT");
        }
    }
}
