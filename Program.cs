using System;
using System.Drawing;

namespace lab_8__Pysachuk
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the 1 triangle: ");
            Console.Write("Vertex 1 (x): ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 1 (y): ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Point1 p1 = new Point1(x1, y1);

            Console.WriteLine("----------------");

            Console.Write("Vertex 2 (x): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 2 (y): ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Point1 p2 = new Point1(x2, y2);

            Console.WriteLine("----------------");

            Console.Write("Vertex 3 (x): ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 3 (y): ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Point1 p3 = new Point1(x3, y3);

            Triangle t1 = new Triangle(p1, p2, p3);

            Console.WriteLine();

            Console.WriteLine("Enter the coordinates of the 2 triangle: ");
            Console.Write("Vertex 1 (x): ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 1 (y): ");
            y1 = Convert.ToDouble(Console.ReadLine());
            p1 = new Point1(x1, y1);

            Console.WriteLine("----------------");

            Console.Write("Vertex 2 (x): ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 2 (y): ");
            y2 = Convert.ToDouble(Console.ReadLine());
            p2 = new Point1(x2, y2);

            Console.WriteLine("----------------");

            Console.Write("Vertex 3 (x): ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 3 (y): ");
            y3 = Convert.ToDouble(Console.ReadLine());
            p3 = new Point1(x3, y3);

            Triangle t2 = new Triangle(p1, p2, p3);

            Console.WriteLine();

            Console.WriteLine("Enter the coordinates of the 3 triangle: ");
            Console.Write("Vertex 1 (x): ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 1 (y): ");
            y1 = Convert.ToDouble(Console.ReadLine());
            p1 = new Point1(x1, y1);

            Console.WriteLine("----------------");

            Console.Write("Vertex 2 (x): ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 2 (y): ");
            y2 = Convert.ToDouble(Console.ReadLine());
            p2 = new Point1(x2, y2);

            Console.WriteLine("----------------");

            Console.Write("Vertex 3 (x): ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vertex 3 (y): ");
            y3 = Convert.ToDouble(Console.ReadLine());
            p3 = new Point1(x3, y3);

            Triangle t3 = new Triangle(p1, p2, p3);

            Console.WriteLine("----------------");

            Console.WriteLine();
            Console.WriteLine("Information about the triangles:");
            Console.WriteLine();

            Console.WriteLine("Triangle 1: ");
            t1.Print();
            Console.WriteLine();

            Console.WriteLine("Triangle 2: ");
            t2.Print();
            Console.WriteLine();

            Console.WriteLine("Triangle 3: ");
            t3.Print();
            Console.WriteLine();

            Triangle closestTriangle = null;
            double closestDistance = double.MaxValue;
            Point1 zero = new Point1(0, 0);

            double distanceToVertex1 = t1.Distance(t1.vertex1, zero);
            double distanceToVertex2 = t1.Distance(t1.vertex2, zero);
            double distanceToVertex3 = t1.Distance(t1.vertex3, zero);
            double minDistance = Math.Min(distanceToVertex1, Math.Min(distanceToVertex2, distanceToVertex3));

            if (minDistance < closestDistance)
            {
                closestDistance = minDistance;
                closestTriangle = t1;
            }

            distanceToVertex1 = t2.Distance(t2.vertex1, zero);
            distanceToVertex2 = t2.Distance(t2.vertex2, zero);
            distanceToVertex3 = t2.Distance(t2.vertex3, zero);
            minDistance = Math.Min(distanceToVertex1, Math.Min(distanceToVertex2, distanceToVertex3));

            if (minDistance < closestDistance)
            {
                closestDistance = minDistance;
                closestTriangle = t2;
            }

            distanceToVertex1 = t3.Distance(t3.vertex1, zero);
            distanceToVertex2 = t3.Distance(t3.vertex2, zero);
            distanceToVertex3 = t3.Distance(t3.vertex3, zero);
            minDistance = Math.Min(distanceToVertex1, Math.Min(distanceToVertex2, distanceToVertex3));

            if (minDistance < closestDistance)
            {
                closestDistance = minDistance;
                closestTriangle = t3;
            }

            Console.WriteLine("Closest triangle to (0;0): ");
            closestTriangle.Print();

            Console.ReadKey();
        }
    }
}
