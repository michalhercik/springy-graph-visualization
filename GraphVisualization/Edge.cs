using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphVisualization
{
    class Edge
    {
        public Node n1, n2;
        public double Cost;
        public Pen Pen = new Pen(Color.Green, 2);

        public Edge(Node n1, Node n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            CalculateCost();
        }

        public void CalculateCost()
        {
            Cost = Math.Sqrt(Math.Pow(n1.X - n2.X, 2) + Math.Pow(n1.Y - n2.Y, 2));
        }

        public void ResetColor()
        {
            Pen.Color = Color.Green;
        }

        public override string ToString()
        {
            return $"{(int)Cost}";
        }
    }
}
