namespace Geometry
{
    internal class Square : Polygon
    {
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

        public Square()
        {
            Points[0] = new Point(0, 1);
            Points[1] = new Point(1, 2);
            Points[2] = new Point(0, 3);
            Points[3] = new Point(1, 4);
            Linestrength = 1;
            Linecolor = ConsoleColor.White;
        }

        //calculate the area of the square
        public double Area()
        {
            double a = Points[0].Distance(Points[1]);
            double b = Points[1].Distance(Points[2]);
            return a * b;
        }

        //calculate if a point is inside the square
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

        public void AddPoint(Point p, int index)
        {
            index = index - 1;
            if (index < 0 || index > 3)
            {
                throw new InvalidOperationException("Index must be between 1 and 4");
            }

            Points[index] = p;
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
