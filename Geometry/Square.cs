namespace Geometry
{
    /// <summary>
    /// Square
    /// 
    /// </summary>
    internal class Square : Polygon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="points"> List of points that form a Square</param>
        /// <param name="linestrength">The strength of the drawline</param>
        /// <param name="linecolor">The Color of the drawline</param>
        /// <exception cref="InvalidOperationException">Exception if there are more or less points than 4</exception>
        public Square(Point[] points, int linestrength, ConsoleColor linecolor)
            : base(points, linestrength, linecolor)
        {
            if (points.Length != 4)
            {
                throw new InvalidOperationException(
                    "Square needs 4 Points/is only capable of having 4 Points"
                );
            }
        }

        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Square()
        {
            Points[0] = new Point(0, 1);
            Points[1] = new Point(1, 2);
            Points[2] = new Point(0, 3);
            Points[3] = new Point(1, 4);
            Linestrength = 1;
            Linecolor = ConsoleColor.White;
        }

        /// <summary>
        /// Calculates the Area of the Square
        /// </summary>
        /// <returns>Area</returns>
        public double Area()
        {
            double a = Points[0].Distance(Points[1]);
            double b = Points[1].Distance(Points[2]);
            return a * b;
        }

        /// <summary>
        /// Calculates if the point is inside the Square
        /// </summary>
        /// <param name="p">the point that needs to be checked</param>
        /// <returns>True or False</returns>
        public bool IsInside(Point p)
        {
            double a = Points[0].Distance(Points[1]);
            double b = Points[1].Distance(Points[2]);
            double c = Points[2].Distance(Points[3]);
            double d = Points[3].Distance(Points[0]);
            double s = (a + b + c + d) / 2;
            Point[] points1 = { Points[0], Points[1], p };
            Point[] points2 = { Points[1], Points[2], p };
            Point[] points3 = { Points[2], Points[3], p };
            Point[] points4 = { Points[3], Points[0], p };
            double s1 = new Triangle(points1, Linestrength, Linecolor).Area();
            double s2 = new Triangle(points2, Linestrength, Linecolor).Area();
            double s3 = new Triangle(points3, Linestrength, Linecolor).Area();
            double s4 = new Triangle(points4, Linestrength, Linecolor).Area();
            return Math.Abs(s - (s1 + s2 + s3 + s4)) < 0.0001;
        }

        /// <summary>
        /// Adds a point to the Square
        /// </summary>
        /// <param name="p">Point</param>
        /// <param name="index">index which point needs to be replaced</param>
        /// <exception cref="InvalidOperationException">Exception if try to add a point below 1 and above </exception>
        public void AddPoint(Point p, int index)
        {
            index = index - 1;
            if (index < 0 || index > 3)
            {
                throw new InvalidOperationException("Index must be between 1 and 4");
            }

            Points[index] = p;
        }
        /// <summary>
        /// To String
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
