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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
