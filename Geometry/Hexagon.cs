namespace Geometry
{
    /// <summary>
    /// Hexagon
    /// </summary>
    internal class Hexagon : Polygon
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="points">List of points that form a Hexagon</param>
        /// <param name="linestrength">The strength of the drawline</param>
        /// <param name="linecolor">The Color of the drawline</param>
        /// <exception cref="InvalidOperationException">Exception if there are more or less points than 6</exception>
        public Hexagon(Point[] points, int linestrength, ConsoleColor linecolor)
            : base(points, linestrength, linecolor)
        {
            if (points.Length != 6)
            {
                throw new InvalidOperationException(
                    "Hexagon needs 6 Points/is only capable of having 6 Points"
                );
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
