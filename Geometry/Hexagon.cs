namespace Geometry
{
    internal class Hexagon : Polygon
    {
        public Hexagon(Point[] points, int linestrength, ConsoleColor linecolor) : base(points, linestrength, linecolor)
        {
            if (points.Length != 6)
            {
                throw new InvalidOperationException("Hexagon needs 6 Points/is only capable of having 6");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
