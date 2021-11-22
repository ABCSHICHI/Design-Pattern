using Abstract_Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern.EntityClass.ColorClass
{
    class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
