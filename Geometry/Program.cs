using Geometry;

Point p1 = new(1, 2);
Point p2 = new(3, 4);
Point p3 = new(1, 6);
Triangle t = new(p1, p2, p3);
Console.WriteLine(t.Area());
