using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Point
    /// </summary>
    internal class Point
    {
        public long X { get; set; }
        public long Y { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        public Point(long x, long y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>String of Point</returns>
        public override string ToString()
        {
            return $"({X}/{Y})";
        }

        /// <summary>
        /// Calculates the Distance between two Points
        /// </summary>
        /// <param name="other">The point which distance needs to be calculated</param>
        /// <returns>distance between those two points</returns>
        public double Distance(Point other)
        {
            long xDiff = X - other.X;
            long yDiff = Y - other.Y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }

        /// <summary>
        /// Mirror the Point on the X-Axis
        /// </summary>
        /// <returns>New point Mirrored on X-Axis</returns>
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
