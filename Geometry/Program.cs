using Geometry;

Point p1 = new Point(1, 2);
Point p2 = new Point(3, 4);
//Circle c1 = new(p1, p2);
//Console.WriteLine(c1.Area());
//Console.WriteLine(c1.Circumference());
//Console.WriteLine(c1.Diameter());
//Console.WriteLine(c1.Radius());
//Console.WriteLine(c1.IsInside(new(2, 3)));
//Console.WriteLine(c1.IsInside(new(4, 5)));
Point[] points = {p1,p2};
Console.WriteLine(points.Length);
Polygon poly = new(points);
poly.RemovePoint(p2);
Console.WriteLine(poly.Points);