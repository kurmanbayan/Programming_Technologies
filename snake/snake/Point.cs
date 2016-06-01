using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Point
    {
        public int x, y;
        private double v;

        public Point() { }

        public Point(double v)
        {
            this.v = v;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
