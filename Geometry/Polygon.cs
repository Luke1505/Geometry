
namespace Geometry
{
    internal class Polygon
    {
        
        private int Linestrength;
        private int Linecolor;
        private Point[] Points;


        public Polygon(Point[] points, int linestrength, int linecolor)
        {
            Linecolor = linecolor;
            Linestrength = linestrength;
            points = points;

        }


        public override string ToString()
        {

            string output = "";

            foreach(var p in Points)
                output += p.ToString() +", ";

            return output;
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

            for (int i = 0; i < Points.Length -1; i++)
            {
                circumference += Points[i].Distance(Points[i + 1]);
            }

            circumference += Points[0].Distance(Points[Points.Length -1]);

            return circumference;
        }

    }
}
