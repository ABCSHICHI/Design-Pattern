using Bridge_Pattern.DrawAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern.AbstractObj
{
    class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, IDraw iDraw):base(iDraw)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            iDraw.DrawCircle(radius, x, y);
        }
    }
}
