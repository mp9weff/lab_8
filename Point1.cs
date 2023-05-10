using System;

namespace lab_8__Pysachuk
{
    public struct Point1
    {
        public double x, y;

        public Point1(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
