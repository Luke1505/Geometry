using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{   
    /// <summary>
    /// Triangle
    /// </summary>
    internal class Triangle : Polygon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="points">List of points that form a Triangle</param>
        /// <param name="linestrength">The strength of the drawline</param>
        /// <param name="linecolor">The Color of the drawline</param>
        /// <exception cref="InvalidOperationException">Exception if there are more or less points than 3</exception>
        public Triangle(Point[] points, int linestrength, int linecolor)
            : base(points, linestrength, linecolor)
        {
            if (points.Length != 3)
            {
                throw new InvalidOperationException(
                    "Triangle needs 3 Points/is only capable of having 3 Points"
                );
            }
        }
        /// <summary>
        /// Standard Constructor
        /// </summary>        
        public Triangle()
        {
            Points[0] = new Point(0,1);
            Points[1] = new Point(1,2);
            Points[2] = new Point(0,3);

            Linestrength = 1;
            Linecolor = 1;
        }

        /// <summary>
        /// Calculates the Area of the Triangle
        /// </summary>
        /// <returns>Area</returns>
        public double Area()
        {
            return 0.5 * Math.Abs(Points[0].X * (Points[1].Y - Points[2].Y) + Points[1].X * (Points[2].Y - Points[0].Y) + Points[2].X * (Points[0].Y - Points[1].Y));
        }

        /// <summary>
        /// Calculates if the point is inside the Triangle
        /// </summary>
        /// <param name="p">Point</param>
        /// <returns>True or False</returns>
        public bool IsInside(Point p)
        {
            double a = Points[0].Distance(Points[1]);
            double b = Points[1].Distance(Points[2]);
            double c = Points[2].Distance(Points[0]);
            double s = (a + b + c) / 2;
            Point[] points1 = { Points[0], Points[1], p };
            Point[] points2 = { Points[1], Points[2], p };
            Point[] points3 = { Points[2], Points[0], p };
            double s1 = new Triangle(points1, Linestrength, Linecolor).Area();
            double s2 = new Triangle(points2, Linestrength, Linecolor).Area();
            double s3 = new Triangle(points3, Linestrength, Linecolor).Area();
            return Math.Abs(s - (s1 + s2 + s3)) < 0.0001;
        }
    }
}
