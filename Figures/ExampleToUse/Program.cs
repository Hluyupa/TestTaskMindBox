// See https://aka.ms/new-console-template for more information
using ShapesAreaLibrary;

Shape circle = new Circle(2);
Console.WriteLine(circle.Area);
Triangle triangle = new Triangle(25, 24, 7);
Console.WriteLine(triangle.Area);
Console.WriteLine(triangle.IsRightAngle);