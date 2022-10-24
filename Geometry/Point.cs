using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }

        //Distance to another point
        public double Distance(Point other)
        {
            int xDiff = X - other.X;
            int yDiff = Y - other.Y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        //Mirror on x axis and return new point
        public Point MirrorX()
        {
            return new Point(X, -Y);
        }

        //Mirror on y axis and return new point
        public Point MirrorY()
        {
            return new Point(-X, Y);
        }
    }
}
