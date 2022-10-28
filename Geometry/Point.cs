using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry
{
    internal class Point
    {
        public long X { get; set; }
        public long Y { get; set; }

        public Point(long x, long y)
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
            return $"({X}/{Y})";
        }
        public double Distance(Point other)
        {
            long xDiff = X - other.X;
            long yDiff = Y - other.Y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        public Point MirrorX()
        {
            return new Point(X, -Y);
        }

        public Point MirrorY()
        {
            return new Point(-X, Y);
        }
    }
}
