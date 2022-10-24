using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Circle
    {
        private Point Center { get; set; }
        private Point OuterPoint { get; set; }

        public Circle(Point center, Point outerPoint)
        {
            Center = center;
            OuterPoint = outerPoint;
        }

        public Circle()
        {
            Center = new Point();
            OuterPoint = new Point();
        }

        public double Area()
        {
            double radius = Center.Distance(OuterPoint);
            return Math.PI * radius * radius;
        }

        public double Circumference()
        {
            double radius = Center.Distance(OuterPoint);
            return 2 * Math.PI * radius;
        }

        public double Diameter()
        {
            double radius = Center.Distance(OuterPoint);
            return 2 * radius;
        }

        public double Radius()
        {
            return Center.Distance(OuterPoint);
        }

        public bool IsInside(Point point)
        {
            return Center.Distance(point) < Radius();
        }
    }
}
