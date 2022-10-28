namespace Geometry
{
    internal class Polygon
    {
        public int Linestrength { get; set; }
        public ConsoleColor Linecolor { get; set; }
        public Point[] Points { get; private set; }

        public Polygon(Point[] points, int linestrength, ConsoleColor linecolor)
        {
            Linecolor = linecolor;
            Linestrength = linestrength;
            Points = points;
        }

        public Polygon()
        {
            this.Points[0] = new Point();
            this.Points[1] = new Point();
            this.Points[2] = new Point();
        }

        private string Stringbuilder()
        {
            string output = "";

            for (int i = 0; i < Points.Length; i++)
            {
                Point p = Points[i];
                if (i == Points.Length - 1)
                {
                    output += p.ToString();
                }
                else
                {
                    output += p.ToString() + ", ";
                }
            }
            return output;
        }

        public override string ToString()
        {
            return Stringbuilder();
        }
        public void AddPoint(Point point)
        {
            Points = Points.Append(point).ToArray();
        }

        public void RemovePoint(Point point)
        {
            Points = Points.Except(new Point[] { point }).ToArray();
        }

        public double Circumference()
        {
            double circumference = 0;

            for (int i = 0; i < Points.Length - 1; i++)
            {
                circumference += Points[i].Distance(Points[i + 1]);
            }

            circumference += Points[0].Distance(Points[Points.Length - 1]);

            return circumference;
        }
    }
}
