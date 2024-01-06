// See https://aka.ms/new-console-template for more information

using GenericsExample;

Console.WriteLine("Hello, World!");

Point<int, double> point = new Point<int, double>();
Point<int, int> point1 = new Point<int, int>();
Point<double, int> point2 = new Point<double, int>();


point.x = 1;
point.y = 2.5;

SuperPoint<int, string, double> superPoint = new SuperPoint<int, string, double>();
superPoint.x = 5;
superPoint.y = "Rajib Rari";
superPoint.Z = 10.5;
