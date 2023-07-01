using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class Vector
    {
        public double Distance;
        public double X;
        public double Y;

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
            Distance = Math.Sqrt(x * x + y * y);
        }

        public void Add(Vector v)
        {
            X += v.X;
            Y += v.Y;
        }

        public void Mult(double a)
        {
            X = a * X;
            Y = a * Y;
        }

        public static Vector operator+ (Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator* (double a, Vector v)
        {
            return new Vector(a * v.X, a * v.Y);
        }
    }
}
