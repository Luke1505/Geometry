using System.Linq;

namespace Geometry
{
    /// <summary>
    /// Polygon
    /// </summary>
    internal class Polygon
    {
        public int Linestrength { get; set; }
        public int Linecolor { get; set; }
        public Point[] Points { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="points"></param>
        /// <param name="linestrength"></param>
        /// <param name="linecolor"></param>
        public Polygon(Point[] points, int linestrength, int linecolor)
        {
            Linecolor = linecolor;
            Linestrength = linestrength;
            Points = points;
        }

        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Polygon()
        {
            this.Points[0] = new Point();
            this.Points[1] = new Point();
            this.Points[2] = new Point();
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>List of Points in the form</returns>
        public override string ToString()
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

        /// <summary>
        /// Adds a Point to the Polygon
        /// </summary>
        /// <param name="point">The point you want to add</param>
        public void AddPoint(Point point)
        {
            Points = Points.Append(point).ToArray();
        }

        /// <summary>
        /// Removes a Point from the Polygon
        /// </summary>
        /// <param name="point">The point you want to remove</param>
        public void RemovePoint(Point point)
        {
            Points = Points.Except(new Point[] { point }).ToArray();
        }

        /// <summary>
        /// Calculates the Circumference of the Polygon
        /// </summary>
        /// <returns>Circumference</returns>
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
