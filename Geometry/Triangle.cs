using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle
    {
        private Point One { get; set; }
        private Point Two { get; set; }
        private Point Three { get; set; }

        public Triangle(Point one, Point two, Point three)
        {
            One = one;
            Two = two;
            Three = three;
        }

        public Triangle()
        {
            One = new Point();
            Two = new Point();
            Three = new Point();
        }

        public double Area()
        {
            double a = One.Distance(Two);
            double b = Two.Distance(Three);
            double c = Three.Distance(One);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public double Perimeter()
        {
            double a = One.Distance(Two);
            double b = Two.Distance(Three);
            double c = Three.Distance(One);
            return a + b + c;
        }

        public double Angle(Point one, Point two)
        {
            double a = one.Distance(two);
            double b = two.Distance(Three);
            double c = Three.Distance(one);
            return Math.Acos((a * a + b * b - c * c) / (2 * a * b));
        }
    }
}
