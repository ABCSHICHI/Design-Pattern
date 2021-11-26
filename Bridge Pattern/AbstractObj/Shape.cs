using Bridge_Pattern.DrawAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.AbstractObj
{
    public abstract class Shape
    {
        protected IDraw iDraw;
        protected Shape(IDraw iDraw)
        {
            this.iDraw = iDraw;
        }
        public abstract void Draw();
    }
}
