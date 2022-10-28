﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle : Polygon
    {
        public Triangle(Point[] points, int linestrength, ConsoleColor linecolor) : base(points, linestrength,linecolor)
        {
        }

        public Triangle()
        {
            Points[0] = new Point();
            Points[1] = new Point();
            Points[2] = new Point();
        }

        public double Area()
        {
            double a = Points[0].Distance(Points[1]);
            double b = Points[1].Distance(Points[2]);
            double c = Points[2].Distance(Points[0]);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

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

        public double Angle(Point one, Point two)
        {
            return 1 ;
        }
    }
}
