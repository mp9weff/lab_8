using System;

namespace lab_8__Pysachuk
{
    public class Triangle
    {
        public Point1 vertex1, vertex2, vertex3;

        public Triangle(Point1 v1, Point1 v2, Point1 v3)
        {
            vertex1 = v1;
            vertex2 = v2;
            vertex3 = v3;
        }

        public double Distance(Point1 p1, Point1 p2)
        {
            double dx = p1.x - p2.x;
            double dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double Perimeter()
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);
            return a + b + c;
        }

        public double Square()
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);
            double pivP = (a + b + c) / 2;
            return Math.Sqrt(pivP * (pivP - a) * (pivP - b) * (pivP - c));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle vertices: {vertex1.ToString()}, {vertex2.ToString()}, {vertex3.ToString()}");
            Console.WriteLine($"P = {Perimeter()}");
            Console.WriteLine($"S = {Square()}");
        }
    }
}
