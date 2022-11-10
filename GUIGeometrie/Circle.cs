using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Geometry Circle
    /// </summary>
    internal class Circle
    {
        private Point Center { get; set; }
        private Point OuterPoint { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="center">center point of the Circle </param>
        /// <param name="outerPoint">one outer point of the circle</param>
        public Circle(Point center, Point outerPoint)
        {
            Center = center;
            OuterPoint = outerPoint;
        }

        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Circle()
        {
            Center = new Point();
            OuterPoint = new Point();
        }

        /// <summary>
        /// Calculates the Area of the Circle
        /// </summary>
        /// <returns>Area of the Circle</returns>
        public double Area()
        {
            double radius = Center.Distance(OuterPoint);
            return Math.PI * Math.Pow(radius,2);
        }

        /// <summary>
        /// Calculates the Circumference of the Circle
        /// </summary>
        /// <returns>Circumference</returns>
        public double Circumference()
        {
            double radius = Center.Distance(OuterPoint);
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Calculates the Diameter of the Circle
        /// </summary>
        /// <returns>Diameter</returns>
        public double Diameter()
        {
            double radius = Center.Distance(OuterPoint);
            return 2 * radius;
        }

        /// <summary>
        /// Calculate the Radius of the Circle
        /// </summary>
        /// <returns>Radius</returns>
        public double Radius()
        {
            return Center.Distance(OuterPoint);
        }

        /// <summary>
        /// Calculates if a Point is inside the Circle
        /// </summary>
        /// <param name="point">The point to check</param>
        /// <returns>True or False</returns>
        public bool IsInside(Point point)
        {
            return Center.Distance(point) < Radius();
        }
    }
}
