
namespace Geometry
{
    internal class Polygon
    {
        
        private int _linestrength;
        private int _linecolor;
        private Point[] _punkte;


        public Polygon(Point[] punkte, int linestrength, int linecolor)
        {
            _linecolor = linecolor;
            _linestrength = linestrength;
            _punkte = punkte;

        }


        public override string ToString()
        {

            string output = "";

            foreach(var p in _punkte)
                output += p.ToString() +", ";

            return output;
        }


        public void AddPoint(Point punkt)
        {
            _punkte = _punkte.Append(punkt).ToArray();
        }


        public double Circumference()
        {

            double circumference = 0;

            for (int i = 0; i < _punkte.Length -1; i++)
            {
                circumference += _punkte[i].Distance(_punkte[i + 1]);
            }

            circumference += _punkte[0].Distance(_punkte[_punkte.Length -1]);

            return circumference;
        }

    }
}
